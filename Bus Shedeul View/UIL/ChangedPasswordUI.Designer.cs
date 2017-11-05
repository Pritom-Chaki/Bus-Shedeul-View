namespace Bus_Shedeul_View.UIL
{
    partial class ChangedPasswordUI
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
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Red;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(216, 252);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 40);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(54, 252);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 40);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "CON&FIRM";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.BackColor = System.Drawing.Color.Coral;
            this.infoGroupBox.Controls.Add(this.panel1);
            this.infoGroupBox.Controls.Add(this.label1);
            this.infoGroupBox.Controls.Add(this.backButton);
            this.infoGroupBox.Controls.Add(this.newPasswordTextBox);
            this.infoGroupBox.Controls.Add(this.addButton);
            this.infoGroupBox.Controls.Add(this.oldPasswordTextBox);
            this.infoGroupBox.Controls.Add(this.nameTextBox);
            this.infoGroupBox.Controls.Add(this.oldPasswordLabel);
            this.infoGroupBox.Controls.Add(this.NewPasswordLabel);
            this.infoGroupBox.Controls.Add(this.nameLabel);
            this.infoGroupBox.Location = new System.Drawing.Point(180, 50);
            this.infoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.infoGroupBox.Size = new System.Drawing.Size(358, 350);
            this.infoGroupBox.TabIndex = 4;
            this.infoGroupBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Location = new System.Drawing.Point(0, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 27);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "CHANGE PASSWORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.Color.Coral;
            this.newPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordTextBox.Location = new System.Drawing.Point(151, 202);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(183, 26);
            this.newPasswordTextBox.TabIndex = 5;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.BackColor = System.Drawing.Color.Coral;
            this.oldPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldPasswordTextBox.Location = new System.Drawing.Point(151, 150);
            this.oldPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(183, 26);
            this.oldPasswordTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Coral;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(151, 100);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(183, 26);
            this.nameTextBox.TabIndex = 3;
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.oldPasswordLabel.Location = new System.Drawing.Point(8, 152);
            this.oldPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(135, 19);
            this.oldPasswordLabel.TabIndex = 2;
            this.oldPasswordLabel.Text = "OLD PASSWORD";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewPasswordLabel.Location = new System.Drawing.Point(8, 204);
            this.NewPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(138, 19);
            this.NewPasswordLabel.TabIndex = 1;
            this.NewPasswordLabel.Text = "NEW PASSWORD";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(37, 102);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "NAME";
            // 
            // ChangedPasswordUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.infoGroupBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ChangedPasswordUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}