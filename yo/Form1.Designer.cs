namespace yo
{
    partial class Form1
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
            this.btnSendYo = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtYoUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErr = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendYo
            // 
            this.btnSendYo.Location = new System.Drawing.Point(361, 14);
            this.btnSendYo.Name = "btnSendYo";
            this.btnSendYo.Size = new System.Drawing.Size(178, 23);
            this.btnSendYo.TabIndex = 0;
            this.btnSendYo.Text = "Send A Yo To All Subscribers";
            this.btnSendYo.UseVisualStyleBackColor = true;
            this.btnSendYo.Click += new System.EventHandler(this.btnSendYo_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(105, 13);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(250, 20);
            this.txtToken.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "your_api_token";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yo Individual Usernames";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnYoIndividual_Click);
            // 
            // txtYoUserName
            // 
            this.txtYoUserName.Location = new System.Drawing.Point(105, 55);
            this.txtYoUserName.Name = "txtYoUserName";
            this.txtYoUserName.Size = new System.Drawing.Size(250, 20);
            this.txtYoUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Location = new System.Drawing.Point(367, 93);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(0, 13);
            this.lblErr.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Count Total Subscribers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CountTotal_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(656, 24);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 128);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtYoUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSendYo);
            this.Name = "Form1";
            this.Text = "Send YO !!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendYo;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtYoUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCount;
    }
}

