﻿namespace Bus_Shedeul_View.UIL
{
    partial class TypeOfTripUI
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
            this.viewGroupBox = new System.Windows.Forms.GroupBox();
            this.typeOfTripDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SAVEButton = new System.Windows.Forms.Button();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.noOfSeatTextBox = new System.Windows.Forms.TextBox();
            this.typeNameTextBox = new System.Windows.Forms.TextBox();
            this.typeNoTextBox = new System.Windows.Forms.TextBox();
            this.busNameLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.typeNoLabel = new System.Windows.Forms.Label();
            this.viewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfTripDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.viewGroupBox.Controls.Add(this.typeOfTripDataGridView);
            this.viewGroupBox.ForeColor = System.Drawing.Color.Red;
            this.viewGroupBox.Location = new System.Drawing.Point(17, 313);
            this.viewGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.viewGroupBox.Size = new System.Drawing.Size(650, 240);
            this.viewGroupBox.TabIndex = 9;
            this.viewGroupBox.TabStop = false;
            this.viewGroupBox.Text = "ALL DATA";
            // 
            // typeOfTripDataGridView
            // 
            this.typeOfTripDataGridView.AllowUserToAddRows = false;
            this.typeOfTripDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfTripDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.typeOfTripDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.typeOfTripDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeOfTripDataGridView.Location = new System.Drawing.Point(0, 20);
            this.typeOfTripDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.typeOfTripDataGridView.Name = "typeOfTripDataGridView";
            this.typeOfTripDataGridView.RowHeadersVisible = false;
            this.typeOfTripDataGridView.Size = new System.Drawing.Size(650, 220);
            this.typeOfTripDataGridView.TabIndex = 0;
            this.typeOfTripDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.typeOfTripDataGridView_DataBindingComplete);
            this.typeOfTripDataGridView.SelectionChanged += new System.EventHandler(this.typeOfTripDataGridView_SelectionChanged);
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
            this.groupBox2.Location = new System.Drawing.Point(78, 225);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(560, 80);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Yellow;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(332, 21);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 40);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(226, 21);
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
            this.updateButton.Location = new System.Drawing.Point(116, 21);
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
            this.BackButton.Location = new System.Drawing.Point(440, 21);
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
            this.SAVEButton.Location = new System.Drawing.Point(8, 21);
            this.SAVEButton.Margin = new System.Windows.Forms.Padding(4);
            this.SAVEButton.Name = "SAVEButton";
            this.SAVEButton.Size = new System.Drawing.Size(100, 40);
            this.SAVEButton.TabIndex = 0;
            this.SAVEButton.Text = "SAVE";
            this.SAVEButton.UseVisualStyleBackColor = false;
            this.SAVEButton.Click += new System.EventHandler(this.SAVEButton_Click);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoGroupBox.Controls.Add(this.noOfSeatTextBox);
            this.infoGroupBox.Controls.Add(this.typeNameTextBox);
            this.infoGroupBox.Controls.Add(this.typeNoTextBox);
            this.infoGroupBox.Controls.Add(this.busNameLabel);
            this.infoGroupBox.Controls.Add(this.ContactLabel);
            this.infoGroupBox.Controls.Add(this.typeNoLabel);
            this.infoGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGroupBox.Location = new System.Drawing.Point(176, 7);
            this.infoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.infoGroupBox.Size = new System.Drawing.Size(380, 210);
            this.infoGroupBox.TabIndex = 7;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Add New Trip Type";
            // 
            // noOfSeatTextBox
            // 
            this.noOfSeatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.noOfSeatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noOfSeatTextBox.Location = new System.Drawing.Point(139, 131);
            this.noOfSeatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.noOfSeatTextBox.Name = "noOfSeatTextBox";
            this.noOfSeatTextBox.Size = new System.Drawing.Size(216, 26);
            this.noOfSeatTextBox.TabIndex = 5;
            // 
            // typeNameTextBox
            // 
            this.typeNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.typeNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeNameTextBox.Location = new System.Drawing.Point(139, 86);
            this.typeNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeNameTextBox.Name = "typeNameTextBox";
            this.typeNameTextBox.Size = new System.Drawing.Size(216, 26);
            this.typeNameTextBox.TabIndex = 4;
            // 
            // typeNoTextBox
            // 
            this.typeNoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.typeNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeNoTextBox.Location = new System.Drawing.Point(139, 37);
            this.typeNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeNoTextBox.Name = "typeNoTextBox";
            this.typeNoTextBox.Size = new System.Drawing.Size(216, 26);
            this.typeNoTextBox.TabIndex = 3;
            // 
            // busNameLabel
            // 
            this.busNameLabel.AutoSize = true;
            this.busNameLabel.Location = new System.Drawing.Point(28, 88);
            this.busNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.busNameLabel.Name = "busNameLabel";
            this.busNameLabel.Size = new System.Drawing.Size(86, 19);
            this.busNameLabel.TabIndex = 2;
            this.busNameLabel.Text = "Type Name";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(28, 133);
            this.ContactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(48, 19);
            this.ContactLabel.TabIndex = 1;
            this.ContactLabel.Text = "Other";
            // 
            // typeNoLabel
            // 
            this.typeNoLabel.AutoSize = true;
            this.typeNoLabel.Location = new System.Drawing.Point(38, 37);
            this.typeNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeNoLabel.Name = "typeNoLabel";
            this.typeNoLabel.Size = new System.Drawing.Size(66, 19);
            this.typeNoLabel.TabIndex = 0;
            this.typeNoLabel.Text = "Type No";
            this.typeNoLabel.Click += new System.EventHandler(this.typeNoLabel_Click);
            // 
            // TypeOfTripUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.viewGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.infoGroupBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "TypeOfTripUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.viewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeOfTripDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox viewGroupBox;
        private System.Windows.Forms.DataGridView typeOfTripDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SAVEButton;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.TextBox noOfSeatTextBox;
        private System.Windows.Forms.TextBox typeNameTextBox;
        private System.Windows.Forms.TextBox typeNoTextBox;
        private System.Windows.Forms.Label busNameLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label typeNoLabel;
    }
}