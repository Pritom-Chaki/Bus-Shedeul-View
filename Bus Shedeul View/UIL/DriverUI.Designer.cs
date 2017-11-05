namespace Bus_Shedeul_View
{
    partial class DriverUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.driverNameTextBox = new System.Windows.Forms.TextBox();
            this.driverNoTextBox = new System.Windows.Forms.TextBox();
            this.driverNameLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.driverNoLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SAVEButton = new System.Windows.Forms.Button();
            this.driverDataGridView = new System.Windows.Forms.DataGridView();
            this.viewGroupBox = new System.Windows.Forms.GroupBox();
            this.infoGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDataGridView)).BeginInit();
            this.viewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoGroupBox.Controls.Add(this.contactNoTextBox);
            this.infoGroupBox.Controls.Add(this.driverNameTextBox);
            this.infoGroupBox.Controls.Add(this.driverNoTextBox);
            this.infoGroupBox.Controls.Add(this.driverNameLabel);
            this.infoGroupBox.Controls.Add(this.contactLabel);
            this.infoGroupBox.Controls.Add(this.driverNoLabel);
            this.infoGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGroupBox.Location = new System.Drawing.Point(172, 25);
            this.infoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.infoGroupBox.Size = new System.Drawing.Size(380, 210);
            this.infoGroupBox.TabIndex = 5;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Add New Driver";
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contactNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactNoTextBox.Location = new System.Drawing.Point(127, 139);
            this.contactNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(216, 26);
            this.contactNoTextBox.TabIndex = 5;
            // 
            // driverNameTextBox
            // 
            this.driverNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.driverNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverNameTextBox.Location = new System.Drawing.Point(127, 88);
            this.driverNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.driverNameTextBox.Name = "driverNameTextBox";
            this.driverNameTextBox.Size = new System.Drawing.Size(216, 26);
            this.driverNameTextBox.TabIndex = 4;
            // 
            // driverNoTextBox
            // 
            this.driverNoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.driverNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverNoTextBox.Location = new System.Drawing.Point(127, 37);
            this.driverNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.driverNoTextBox.Name = "driverNoTextBox";
            this.driverNoTextBox.Size = new System.Drawing.Size(216, 26);
            this.driverNoTextBox.TabIndex = 3;
            // 
            // driverNameLabel
            // 
            this.driverNameLabel.AutoSize = true;
            this.driverNameLabel.Location = new System.Drawing.Point(16, 95);
            this.driverNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.driverNameLabel.Name = "driverNameLabel";
            this.driverNameLabel.Size = new System.Drawing.Size(97, 19);
            this.driverNameLabel.TabIndex = 2;
            this.driverNameLabel.Text = "Driver Name";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(28, 146);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(85, 19);
            this.contactLabel.TabIndex = 1;
            this.contactLabel.Text = "Contact No";
            // 
            // driverNoLabel
            // 
            this.driverNoLabel.AutoSize = true;
            this.driverNoLabel.Location = new System.Drawing.Point(28, 44);
            this.driverNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.driverNoLabel.Name = "driverNoLabel";
            this.driverNoLabel.Size = new System.Drawing.Size(77, 19);
            this.driverNoLabel.TabIndex = 0;
            this.driverNoLabel.Text = "Driver No";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BackButton);
            this.groupBox2.Controls.Add(this.SAVEButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(74, 243);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(560, 80);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Yellow;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(341, 21);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 40);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(233, 22);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 40);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(125, 21);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 40);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(218, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(449, 22);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 40);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SAVEButton
            // 
            this.SAVEButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SAVEButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVEButton.Location = new System.Drawing.Point(17, 21);
            this.SAVEButton.Margin = new System.Windows.Forms.Padding(4);
            this.SAVEButton.Name = "SAVEButton";
            this.SAVEButton.Size = new System.Drawing.Size(100, 40);
            this.SAVEButton.TabIndex = 0;
            this.SAVEButton.Text = "SAVE";
            this.SAVEButton.UseVisualStyleBackColor = false;
            this.SAVEButton.Click += new System.EventHandler(this.SAVEButton_Click);
            // 
            // driverDataGridView
            // 
            this.driverDataGridView.AllowUserToAddRows = false;
            this.driverDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.driverDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.driverDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.driverDataGridView.Location = new System.Drawing.Point(8, 20);
            this.driverDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.driverDataGridView.Name = "driverDataGridView";
            this.driverDataGridView.ReadOnly = true;
            this.driverDataGridView.RowHeadersVisible = false;
            this.driverDataGridView.Size = new System.Drawing.Size(642, 220);
            this.driverDataGridView.TabIndex = 0;
            this.driverDataGridView.BackgroundColorChanged += new System.EventHandler(this.cancelButton_Click);
            this.driverDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.driverDataGridView_DataBindingComplete);
            this.driverDataGridView.SelectionChanged += new System.EventHandler(this.driverDataGridView_SelectionChanged);
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.viewGroupBox.Controls.Add(this.driverDataGridView);
            this.viewGroupBox.ForeColor = System.Drawing.Color.Red;
            this.viewGroupBox.Location = new System.Drawing.Point(13, 331);
            this.viewGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.viewGroupBox.Size = new System.Drawing.Size(658, 240);
            this.viewGroupBox.TabIndex = 6;
            this.viewGroupBox.TabStop = false;
            this.viewGroupBox.Text = "ALL DATA";
            // 
            // DriverUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.viewGroupBox);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "DriverUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDataGridView)).EndInit();
            this.viewGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.TextBox driverNameTextBox;
        private System.Windows.Forms.TextBox driverNoTextBox;
        private System.Windows.Forms.Label driverNameLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label driverNoLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SAVEButton;
        private System.Windows.Forms.DataGridView driverDataGridView;
        private System.Windows.Forms.GroupBox viewGroupBox;
    }
}