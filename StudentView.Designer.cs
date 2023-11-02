namespace TicketManagementSystem
{
    partial class StudentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentView));
            this.StudentViewLabel = new System.Windows.Forms.Label();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.createPictureBox = new System.Windows.Forms.PictureBox();
            this.createButton = new System.Windows.Forms.Button();
            this.createLabel = new System.Windows.Forms.Label();
            this.groupBoxView = new System.Windows.Forms.GroupBox();
            this.viewPictureBox = new System.Windows.Forms.PictureBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.viewLabel = new System.Windows.Forms.Label();
            this.logOffButton = new System.Windows.Forms.Button();
            this.groupBoxCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createPictureBox)).BeginInit();
            this.groupBoxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentViewLabel
            // 
            this.StudentViewLabel.AutoSize = true;
            this.StudentViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentViewLabel.Location = new System.Drawing.Point(312, 38);
            this.StudentViewLabel.Name = "StudentViewLabel";
            this.StudentViewLabel.Size = new System.Drawing.Size(604, 55);
            this.StudentViewLabel.TabIndex = 0;
            this.StudentViewLabel.Text = "Student Ticket Dashboard";
            this.StudentViewLabel.Click += new System.EventHandler(this.StudentViewLabel_Click);
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxCreate.Controls.Add(this.createPictureBox);
            this.groupBoxCreate.Controls.Add(this.createButton);
            this.groupBoxCreate.Controls.Add(this.createLabel);
            this.groupBoxCreate.Location = new System.Drawing.Point(289, 146);
            this.groupBoxCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxCreate.Size = new System.Drawing.Size(318, 496);
            this.groupBoxCreate.TabIndex = 1;
            this.groupBoxCreate.TabStop = false;
            // 
            // createPictureBox
            // 
            this.createPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("createPictureBox.Image")));
            this.createPictureBox.Location = new System.Drawing.Point(55, 138);
            this.createPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createPictureBox.Name = "createPictureBox";
            this.createPictureBox.Size = new System.Drawing.Size(213, 206);
            this.createPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.createPictureBox.TabIndex = 2;
            this.createPictureBox.TabStop = false;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(34, 425);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(253, 58);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // createLabel
            // 
            this.createLabel.AutoSize = true;
            this.createLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLabel.Location = new System.Drawing.Point(48, 39);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(225, 38);
            this.createLabel.TabIndex = 0;
            this.createLabel.Text = "Create Ticket";
            // 
            // groupBoxView
            // 
            this.groupBoxView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxView.Controls.Add(this.viewPictureBox);
            this.groupBoxView.Controls.Add(this.viewButton);
            this.groupBoxView.Controls.Add(this.viewLabel);
            this.groupBoxView.Location = new System.Drawing.Point(707, 146);
            this.groupBoxView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxView.Name = "groupBoxView";
            this.groupBoxView.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxView.Size = new System.Drawing.Size(318, 496);
            this.groupBoxView.TabIndex = 2;
            this.groupBoxView.TabStop = false;
            // 
            // viewPictureBox
            // 
            this.viewPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("viewPictureBox.Image")));
            this.viewPictureBox.Location = new System.Drawing.Point(52, 138);
            this.viewPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewPictureBox.Name = "viewPictureBox";
            this.viewPictureBox.Size = new System.Drawing.Size(213, 206);
            this.viewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewPictureBox.TabIndex = 3;
            this.viewPictureBox.TabStop = false;
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(34, 425);
            this.viewButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(253, 58);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLabel.Location = new System.Drawing.Point(49, 39);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(238, 38);
            this.viewLabel.TabIndex = 1;
            this.viewLabel.Text = "View Ticket(s)";
            // 
            // logOffButton
            // 
            this.logOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOffButton.Location = new System.Drawing.Point(950, 38);
            this.logOffButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logOffButton.Name = "logOffButton";
            this.logOffButton.Size = new System.Drawing.Size(160, 50);
            this.logOffButton.TabIndex = 3;
            this.logOffButton.Text = "Log Off";
            this.logOffButton.UseVisualStyleBackColor = true;
            this.logOffButton.Click += new System.EventHandler(this.logOffButton_Click);
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 742);
            this.Controls.Add(this.logOffButton);
            this.Controls.Add(this.groupBoxView);
            this.Controls.Add(this.groupBoxCreate);
            this.Controls.Add(this.StudentViewLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentView";
            this.Text = "Student Dashboard";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createPictureBox)).EndInit();
            this.groupBoxView.ResumeLayout(false);
            this.groupBoxView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentViewLabel;
        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.PictureBox createPictureBox;
        private System.Windows.Forms.PictureBox viewPictureBox;
        private System.Windows.Forms.Button logOffButton;
    }
}