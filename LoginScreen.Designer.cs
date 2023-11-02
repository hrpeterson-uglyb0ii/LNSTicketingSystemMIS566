namespace TicketManagementSystem
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.FrmGrpBox = new System.Windows.Forms.GroupBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FrmGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmGrpBox
            // 
            this.FrmGrpBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FrmGrpBox.Controls.Add(this.button1);
            this.FrmGrpBox.Controls.Add(this.SignUpButton);
            this.FrmGrpBox.Controls.Add(this.pictureBox1);
            this.FrmGrpBox.Controls.Add(this.loginButton);
            this.FrmGrpBox.Controls.Add(this.passwordTextBox);
            this.FrmGrpBox.Controls.Add(this.userTextBox);
            this.FrmGrpBox.Controls.Add(this.label1);
            this.FrmGrpBox.Controls.Add(this.UsernameLabel);
            this.FrmGrpBox.Controls.Add(this.LoginLabel);
            this.FrmGrpBox.Location = new System.Drawing.Point(123, 10);
            this.FrmGrpBox.Name = "FrmGrpBox";
            this.FrmGrpBox.Size = new System.Drawing.Size(1034, 480);
            this.FrmGrpBox.TabIndex = 0;
            this.FrmGrpBox.TabStop = false;
            this.FrmGrpBox.Enter += new System.EventHandler(this.FrmGrpBox_Enter);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.PowderBlue;
            this.SignUpButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(424, 403);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(260, 40);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(411, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.PowderBlue;
            this.loginButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(424, 334);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(260, 40);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(379, 282);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(356, 22);
            this.passwordTextBox.TabIndex = 4;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(379, 220);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(356, 22);
            this.userTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(252, 221);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(110, 21);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "UserName:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Cambria Math", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(276, 86);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(480, 156);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "LNS Education Ticketing System";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "professor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1292, 636);
            this.Controls.Add(this.FrmGrpBox);
            this.Name = "LoginScreen";
            this.Text = "Login Page";
            this.FrmGrpBox.ResumeLayout(false);
            this.FrmGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FrmGrpBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button button1;
    }
}

