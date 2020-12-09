using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Sockets
{
    public partial class Client : Form
    {
        const int MAX_CHARS = 255;
        const int _port = 1038;

        const string CAPTION_ERR = "Помилка";
        const string ERR_TOO_MANY = "Довжина паролю перевищує допустиму";
        const string _serverIp = "127.0.0.1";
        const string _charSet = "abcdefghijklmnopqrstuvwxyz";
        const string _logPath = "E:\\server\\client_log.txt";

        bool _started = false;

        int _passwordLength = 0;
        int _attemptCount = 1;
        int _countdown = 100;

        public Client()
        {
            InitializeComponent();
            File.WriteAllText(_logPath, String.Empty);
        }

        private void Log(string data)
        {
            using (StreamWriter writer = File.AppendText(_logPath))
            {
                writer.WriteLine(data);
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            Submit("connect", out string reply);
            Log("Connected to server at " + DateTime.Now.ToString());

            lengthLabel.Text = lengthLabel.Text + reply;
            _passwordLength = Int32.Parse(reply);

            passwordInfoLabel.Visible = true;
            passwordPicker.Visible = true;
            submitBtn.Visible = true;
            lengthLabel.Visible = true;
            resultLabel.Visible = true;
            attemptLabel.Visible = true;
            infoBtn.Visible = true;
            infoLabel.Visible = true;
            timeLabel.Visible = true;
            connectBtn.Visible = false;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!_started)
            {
                submitBtn.Text = "Submit";
                _started = true;
                passwordPicker.Enabled = true;
                InitializeTimer();
                return;
            }

            Submit(passwordPicker.Text, out string reply);
            ProcessAttempt(reply);
        }

        private void Submit(string message, out string result)
        {

            if (message.Length >= MAX_CHARS)
            {
                MessageBox.Show(ERR_TOO_MANY, CAPTION_ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = "";
                return;
            }

            try
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(_serverIp), _port);
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipPoint);

                byte[] data = Encoding.Unicode.GetBytes(message.Length.ToString() + message);
                socket.Send(data);

                result = ReceiveServerReply(socket);

                socket.Shutdown(SocketShutdown.Both);
                socket.Close();

            }
            catch (Exception ex)
            {
                result = "";
            }
        }

        private string ReceiveServerReply(Socket socket)
        {
            byte[] data = new byte[256];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;

            do
            {
                bytes = socket.Receive(data, data.Length, 0);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (socket.Available > 0);

            return builder.ToString();
        }

        private void passwordPicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string passwordSent = passwordPicker.Text;
                Submit(passwordSent, out string reply);
                Log("Password sent to server at " + DateTime.Now.ToString() + ": " + passwordSent);
                ProcessAttempt(reply);
            }
        }

        private bool ProcessAttempt(string reply)
        {
            passwordPicker.Text = "";
            resultLabel.Text = reply;
            _attemptCount++;
            attemptLabel.Text = "Attempt №" + _attemptCount.ToString();
            
            if (reply.Equals("Password is correct!"))
            {
                timer.Stop();
                passwordPicker.Enabled = false;
                Log("Password cracked successfully at " + DateTime.Now.ToString() + " in " + _attemptCount + " attempts");
                return true;
            }
            return false;
        }


        private void infoBtn_Click(object sender, EventArgs e)
        {
            Submit("who", out string reply);
            infoLabel.Text = reply;
            Log("Info retrieved: " + reply);
        }

        private bool AutoPick(string prefix, int length)
        {

            if (length == 0)
            {
                Submit(prefix, out string reply);
                Log("Attempt password sent to server at " + DateTime.Now.ToString() + ": " + prefix);
                if (!timer.Enabled || ProcessAttempt(reply))
                {
                    return true;
                }
                return false;
            }

            for (int i = 0; i < _charSet.Length; ++i)
            {
                string newPrefix = prefix + _charSet[i];
                if (AutoPick(newPrefix, length - 1))
                {
                    return true;
                }
            }
            return false;
        }

        private void InitializeTimer()
        {
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            _countdown--;
            timeLabel.Text = "Remaining time: " + _countdown.ToString();

            if (_countdown == 0)
            {
                timer.Stop();
                passwordPicker.Enabled = false;
                submitBtn.Enabled = false;
                infoBtn.Enabled = false;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            AutoPick("", (int)e.Argument);
        }
    }
}