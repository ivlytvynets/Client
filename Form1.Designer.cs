namespace Sockets
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.passwordPicker = new System.Windows.Forms.TextBox();
            this.passwordInfoLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.attemptLabel = new System.Windows.Forms.Label();
            this.infoBtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // passwordPicker
            // 
            this.passwordPicker.Enabled = false;
            this.passwordPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordPicker.Location = new System.Drawing.Point(78, 167);
            this.passwordPicker.Name = "passwordPicker";
            this.passwordPicker.Size = new System.Drawing.Size(229, 38);
            this.passwordPicker.TabIndex = 0;
            this.passwordPicker.Visible = false;
            this.passwordPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordPicker_KeyDown);
            // 
            // passwordInfoLabel
            // 
            this.passwordInfoLabel.AutoSize = true;
            this.passwordInfoLabel.Location = new System.Drawing.Point(75, 147);
            this.passwordInfoLabel.Name = "passwordInfoLabel";
            this.passwordInfoLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordInfoLabel.TabIndex = 1;
            this.passwordInfoLabel.Text = "Password";
            this.passwordInfoLabel.Visible = false;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(326, 167);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(78, 38);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Start";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Visible = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(78, 69);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(229, 51);
            this.connectBtn.TabIndex = 3;
            this.connectBtn.Text = "Connect to the server";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(75, 217);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(70, 17);
            this.lengthLabel.TabIndex = 6;
            this.lengthLabel.Text = "Length is ";
            this.lengthLabel.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(78, 248);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 17);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Visible = false;
            // 
            // attemptLabel
            // 
            this.attemptLabel.AutoSize = true;
            this.attemptLabel.Location = new System.Drawing.Point(323, 217);
            this.attemptLabel.Name = "attemptLabel";
            this.attemptLabel.Size = new System.Drawing.Size(82, 17);
            this.attemptLabel.TabIndex = 8;
            this.attemptLabel.Text = "Attempt №1";
            this.attemptLabel.Visible = false;
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(536, 167);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(74, 38);
            this.infoBtn.TabIndex = 9;
            this.infoBtn.Text = "Info";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Visible = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(544, 217);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 17);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(75, 279);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 17);
            this.timeLabel.TabIndex = 12;
            this.timeLabel.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.attemptLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.passwordInfoLabel);
            this.Controls.Add(this.passwordPicker);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox passwordPicker;
        private System.Windows.Forms.Label passwordInfoLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label attemptLabel;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

