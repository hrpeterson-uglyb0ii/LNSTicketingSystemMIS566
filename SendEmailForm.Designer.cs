namespace TicketManagementSystem
{
    partial class SendEmailForm
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
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sendExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailButton.Location = new System.Drawing.Point(637, 105);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(184, 104);
            this.sendEmailButton.TabIndex = 0;
            this.sendEmailButton.Text = "Send Email To Ticket Creator";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click_1);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(324, 105);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(246, 26);
            this.subjectTextBox.TabIndex = 1;
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Location = new System.Drawing.Point(324, 202);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(246, 306);
            this.bodyTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resolution Details:";
            // 
            // sendExit
            // 
            this.sendExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendExit.ForeColor = System.Drawing.Color.Black;
            this.sendExit.Location = new System.Drawing.Point(637, 234);
            this.sendExit.Name = "sendExit";
            this.sendExit.Size = new System.Drawing.Size(184, 104);
            this.sendExit.TabIndex = 5;
            this.sendExit.Text = "Exit";
            this.sendExit.UseVisualStyleBackColor = true;
            this.sendExit.Click += new System.EventHandler(this.sendExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(317, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ticket Resolution";
            // 
            // SendEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1241, 609);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sendExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.sendEmailButton);
            this.Name = "SendEmailForm";
            this.Text = "Ticket Resolution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendExit;
        private System.Windows.Forms.Label label3;
    }
}