namespace Bus_Shedeul_View.UIL
{
    partial class BusShediulUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusShediulUI));
            this.buisLabel = new System.Windows.Forms.Label();
            this.locate1Label = new System.Windows.Forms.Label();
            this.locate2Label = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.driverNameLabel = new System.Windows.Forms.Label();
            this.driverContactLabel = new System.Windows.Forms.Label();
            this.busTextBox = new System.Windows.Forms.TextBox();
            this.locate2TextBox = new System.Windows.Forms.TextBox();
            this.locate1TextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.driverNameTextBox = new System.Windows.Forms.TextBox();
            this.busComboBox = new System.Windows.Forms.ComboBox();
            this.locate2ComboBox = new System.Windows.Forms.ComboBox();
            this.locate1ComboBox = new System.Windows.Forms.ComboBox();
            this.driverNameComboBox = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.busShedulDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SAVEButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.seatLabel = new System.Windows.Forms.Label();
            this.seatTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.contact2TextBox = new System.Windows.Forms.TextBox();
            this.helperContactLabel = new System.Windows.Forms.Label();
            this.helperNameComboBox = new System.Windows.Forms.ComboBox();
            this.helperNameTextBox = new System.Windows.Forms.TextBox();
            this.helperNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busShedulDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buisLabel
            // 
            this.buisLabel.AutoSize = true;
            this.buisLabel.Location = new System.Drawing.Point(28, 44);
            this.buisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buisLabel.Name = "buisLabel";
            this.buisLabel.Size = new System.Drawing.Size(79, 19);
            this.buisLabel.TabIndex = 0;
            this.buisLabel.Text = "Bus Name";
            this.buisLabel.Click += new System.EventHandler(this.buisLabel_Click);
            // 
            // locate1Label
            // 
            this.locate1Label.AutoSize = true;
            this.locate1Label.Location = new System.Drawing.Point(63, 194);
            this.locate1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locate1Label.Name = "locate1Label";
            this.locate1Label.Size = new System.Drawing.Size(44, 19);
            this.locate1Label.TabIndex = 1;
            this.locate1Label.Text = "From";
            this.locate1Label.Click += new System.EventHandler(this.locate1Label_Click);
            // 
            // locate2Label
            // 
            this.locate2Label.AutoSize = true;
            this.locate2Label.Location = new System.Drawing.Point(558, 194);
            this.locate2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locate2Label.Name = "locate2Label";
            this.locate2Label.Size = new System.Drawing.Size(26, 19);
            this.locate2Label.TabIndex = 2;
            this.locate2Label.Text = "To";
            this.locate2Label.Click += new System.EventHandler(this.locate2Label_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(546, 241);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(43, 19);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // driverNameLabel
            // 
            this.driverNameLabel.AutoSize = true;
            this.driverNameLabel.Location = new System.Drawing.Point(10, 94);
            this.driverNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.driverNameLabel.Name = "driverNameLabel";
            this.driverNameLabel.Size = new System.Drawing.Size(97, 19);
            this.driverNameLabel.TabIndex = 4;
            this.driverNameLabel.Text = "Driver Name";
            this.driverNameLabel.Click += new System.EventHandler(this.driverNameLabel_Click);
            // 
            // driverContactLabel
            // 
            this.driverContactLabel.AutoSize = true;
            this.driverContactLabel.Location = new System.Drawing.Point(504, 94);
            this.driverContactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.driverContactLabel.Name = "driverContactLabel";
            this.driverContactLabel.Size = new System.Drawing.Size(85, 19);
            this.driverContactLabel.TabIndex = 5;
            this.driverContactLabel.Text = "Contact No";
            this.driverContactLabel.Click += new System.EventHandler(this.driverContactLabel_Click);
            // 
            // busTextBox
            // 
            this.busTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.busTextBox.Enabled = false;
            this.busTextBox.Location = new System.Drawing.Point(127, 41);
            this.busTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.busTextBox.Name = "busTextBox";
            this.busTextBox.Size = new System.Drawing.Size(178, 26);
            this.busTextBox.TabIndex = 6;
            this.busTextBox.TextChanged += new System.EventHandler(this.busTextBox_TextChanged);
            // 
            // locate2TextBox
            // 
            this.locate2TextBox.Enabled = false;
            this.locate2TextBox.Location = new System.Drawing.Point(604, 191);
            this.locate2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.locate2TextBox.Name = "locate2TextBox";
            this.locate2TextBox.Size = new System.Drawing.Size(178, 26);
            this.locate2TextBox.TabIndex = 7;
            this.locate2TextBox.TextChanged += new System.EventHandler(this.locate2TextBox_TextChanged);
            // 
            // locate1TextBox
            // 
            this.locate1TextBox.Enabled = false;
            this.locate1TextBox.Location = new System.Drawing.Point(127, 191);
            this.locate1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.locate1TextBox.Name = "locate1TextBox";
            this.locate1TextBox.Size = new System.Drawing.Size(178, 26);
            this.locate1TextBox.TabIndex = 8;
            this.locate1TextBox.TextChanged += new System.EventHandler(this.locate1TextBox_TextChanged);
            // 
            // contactTextBox
            // 
            this.contactTextBox.Enabled = false;
            this.contactTextBox.Location = new System.Drawing.Point(604, 91);
            this.contactTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(178, 26);
            this.contactTextBox.TabIndex = 9;
            this.contactTextBox.TextChanged += new System.EventHandler(this.contactTextBox_TextChanged);
            // 
            // driverNameTextBox
            // 
            this.driverNameTextBox.Enabled = false;
            this.driverNameTextBox.Location = new System.Drawing.Point(127, 91);
            this.driverNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.driverNameTextBox.Name = "driverNameTextBox";
            this.driverNameTextBox.Size = new System.Drawing.Size(178, 26);
            this.driverNameTextBox.TabIndex = 10;
            this.driverNameTextBox.TextChanged += new System.EventHandler(this.driverNameTextBox_TextChanged);
            // 
            // busComboBox
            // 
            this.busComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busComboBox.ForeColor = System.Drawing.Color.Black;
            this.busComboBox.FormattingEnabled = true;
            this.busComboBox.Location = new System.Drawing.Point(330, 41);
            this.busComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.busComboBox.Name = "busComboBox";
            this.busComboBox.Size = new System.Drawing.Size(127, 27);
            this.busComboBox.TabIndex = 11;
            this.busComboBox.Text = "All Bus ";
            this.busComboBox.SelectedIndexChanged += new System.EventHandler(this.busComboBox_SelectedIndexChanged);
            // 
            // locate2ComboBox
            // 
            this.locate2ComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locate2ComboBox.FormattingEnabled = true;
            this.locate2ComboBox.Location = new System.Drawing.Point(807, 191);
            this.locate2ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.locate2ComboBox.Name = "locate2ComboBox";
            this.locate2ComboBox.Size = new System.Drawing.Size(127, 27);
            this.locate2ComboBox.TabIndex = 12;
            this.locate2ComboBox.Text = "All Location";
            this.locate2ComboBox.SelectedIndexChanged += new System.EventHandler(this.locate2omboBox_SelectedIndexChanged);
            // 
            // locate1ComboBox
            // 
            this.locate1ComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locate1ComboBox.FormattingEnabled = true;
            this.locate1ComboBox.Location = new System.Drawing.Point(330, 191);
            this.locate1ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.locate1ComboBox.Name = "locate1ComboBox";
            this.locate1ComboBox.Size = new System.Drawing.Size(127, 27);
            this.locate1ComboBox.TabIndex = 13;
            this.locate1ComboBox.Text = "All Location";
            this.locate1ComboBox.SelectedIndexChanged += new System.EventHandler(this.locate1ComboBox_SelectedIndexChanged);
            // 
            // driverNameComboBox
            // 
            this.driverNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverNameComboBox.FormattingEnabled = true;
            this.driverNameComboBox.Location = new System.Drawing.Point(330, 91);
            this.driverNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.driverNameComboBox.Name = "driverNameComboBox";
            this.driverNameComboBox.Size = new System.Drawing.Size(127, 27);
            this.driverNameComboBox.TabIndex = 14;
            this.driverNameComboBox.Text = "All Driver";
            this.driverNameComboBox.SelectedIndexChanged += new System.EventHandler(this.driverNameComboBox_SelectedIndexChanged);
            // 
            // timePicker
            // 
            this.timePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.timePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.timePicker.CalendarTitleForeColor = System.Drawing.Color.White;
            this.timePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.timePicker.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(604, 229);
            this.timePicker.Margin = new System.Windows.Forms.Padding(4);
            this.timePicker.Name = "timePicker";
            this.timePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(156, 35);
            this.timePicker.TabIndex = 15;
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.busShedulDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(10, 406);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(937, 247);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show All Data";
            // 
            // busShedulDataGridView
            // 
            this.busShedulDataGridView.AllowUserToAddRows = false;
            this.busShedulDataGridView.AllowUserToDeleteRows = false;
            this.busShedulDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busShedulDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.busShedulDataGridView.GridColor = System.Drawing.Color.Red;
            this.busShedulDataGridView.Location = new System.Drawing.Point(8, 20);
            this.busShedulDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.busShedulDataGridView.Name = "busShedulDataGridView";
            this.busShedulDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busShedulDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.busShedulDataGridView.Size = new System.Drawing.Size(921, 219);
            this.busShedulDataGridView.TabIndex = 0;
            this.busShedulDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.busShedulDataGridView_DataBindingComplete);
            this.busShedulDataGridView.SelectionChanged += new System.EventHandler(this.busShedulDataGridView_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BackButton);
            this.groupBox2.Controls.Add(this.SAVEButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(138, 312);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(617, 86);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Yellow;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(381, 28);
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
            this.deleteButton.Location = new System.Drawing.Point(264, 28);
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
            this.updateButton.BackColor = System.Drawing.Color.Blue;
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(146, 28);
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
            this.BackButton.Location = new System.Drawing.Point(502, 28);
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
            this.SAVEButton.Location = new System.Drawing.Point(26, 28);
            this.SAVEButton.Margin = new System.Windows.Forms.Padding(4);
            this.SAVEButton.Name = "SAVEButton";
            this.SAVEButton.Size = new System.Drawing.Size(100, 40);
            this.SAVEButton.TabIndex = 0;
            this.SAVEButton.Text = "SAVE";
            this.SAVEButton.UseVisualStyleBackColor = false;
            this.SAVEButton.Click += new System.EventHandler(this.SAVEButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.seatLabel);
            this.groupBox3.Controls.Add(this.seatTextBox);
            this.groupBox3.Controls.Add(this.typeComboBox);
            this.groupBox3.Controls.Add(this.typeTextBox);
            this.groupBox3.Controls.Add(this.typeLabel);
            this.groupBox3.Controls.Add(this.contact2TextBox);
            this.groupBox3.Controls.Add(this.helperContactLabel);
            this.groupBox3.Controls.Add(this.helperNameComboBox);
            this.groupBox3.Controls.Add(this.helperNameTextBox);
            this.groupBox3.Controls.Add(this.helperNameLabel);
            this.groupBox3.Controls.Add(this.timePicker);
            this.groupBox3.Controls.Add(this.driverNameComboBox);
            this.groupBox3.Controls.Add(this.locate1ComboBox);
            this.groupBox3.Controls.Add(this.locate2ComboBox);
            this.groupBox3.Controls.Add(this.busComboBox);
            this.groupBox3.Controls.Add(this.driverNameTextBox);
            this.groupBox3.Controls.Add(this.contactTextBox);
            this.groupBox3.Controls.Add(this.locate1TextBox);
            this.groupBox3.Controls.Add(this.locate2TextBox);
            this.groupBox3.Controls.Add(this.busTextBox);
            this.groupBox3.Controls.Add(this.driverContactLabel);
            this.groupBox3.Controls.Add(this.driverNameLabel);
            this.groupBox3.Controls.Add(this.timeLabel);
            this.groupBox3.Controls.Add(this.locate2Label);
            this.groupBox3.Controls.Add(this.locate1Label);
            this.groupBox3.Controls.Add(this.buisLabel);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(942, 295);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter Data for Schedule";
            // 
            // seatLabel
            // 
            this.seatLabel.AutoSize = true;
            this.seatLabel.Location = new System.Drawing.Point(517, 44);
            this.seatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seatLabel.Name = "seatLabel";
            this.seatLabel.Size = new System.Drawing.Size(80, 19);
            this.seatLabel.TabIndex = 25;
            this.seatLabel.Text = "No of Seat";
            // 
            // seatTextBox
            // 
            this.seatTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.seatTextBox.Enabled = false;
            this.seatTextBox.Location = new System.Drawing.Point(604, 41);
            this.seatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.seatTextBox.Name = "seatTextBox";
            this.seatTextBox.Size = new System.Drawing.Size(178, 26);
            this.seatTextBox.TabIndex = 24;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(330, 241);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(127, 27);
            this.typeComboBox.TabIndex = 23;
            this.typeComboBox.Text = "All Type";
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Enabled = false;
            this.typeTextBox.Location = new System.Drawing.Point(127, 241);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(178, 26);
            this.typeTextBox.TabIndex = 22;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(17, 241);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(90, 19);
            this.typeLabel.TabIndex = 21;
            this.typeLabel.Text = "Type of Trip";
            // 
            // contact2TextBox
            // 
            this.contact2TextBox.Enabled = false;
            this.contact2TextBox.Location = new System.Drawing.Point(604, 141);
            this.contact2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contact2TextBox.Name = "contact2TextBox";
            this.contact2TextBox.Size = new System.Drawing.Size(178, 26);
            this.contact2TextBox.TabIndex = 20;
            // 
            // helperContactLabel
            // 
            this.helperContactLabel.AutoSize = true;
            this.helperContactLabel.Location = new System.Drawing.Point(504, 144);
            this.helperContactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.helperContactLabel.Name = "helperContactLabel";
            this.helperContactLabel.Size = new System.Drawing.Size(85, 19);
            this.helperContactLabel.TabIndex = 19;
            this.helperContactLabel.Text = "Contact No";
            // 
            // helperNameComboBox
            // 
            this.helperNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helperNameComboBox.FormattingEnabled = true;
            this.helperNameComboBox.Location = new System.Drawing.Point(330, 141);
            this.helperNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.helperNameComboBox.Name = "helperNameComboBox";
            this.helperNameComboBox.Size = new System.Drawing.Size(127, 27);
            this.helperNameComboBox.TabIndex = 18;
            this.helperNameComboBox.Text = "All Helper";
            this.helperNameComboBox.SelectedIndexChanged += new System.EventHandler(this.helperNameComboBox_SelectedIndexChanged);
            // 
            // helperNameTextBox
            // 
            this.helperNameTextBox.Enabled = false;
            this.helperNameTextBox.Location = new System.Drawing.Point(127, 141);
            this.helperNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.helperNameTextBox.Name = "helperNameTextBox";
            this.helperNameTextBox.Size = new System.Drawing.Size(178, 26);
            this.helperNameTextBox.TabIndex = 17;
            // 
            // helperNameLabel
            // 
            this.helperNameLabel.AutoSize = true;
            this.helperNameLabel.Location = new System.Drawing.Point(8, 144);
            this.helperNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.helperNameLabel.Name = "helperNameLabel";
            this.helperNameLabel.Size = new System.Drawing.Size(99, 19);
            this.helperNameLabel.TabIndex = 16;
            this.helperNameLabel.Text = "Helper Name";
            // 
            // BusShediulUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(960, 657);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BusShediulUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Bus Time";
            this.Load += new System.EventHandler(this.BusShediulUI_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.busShedulDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buisLabel;
        private System.Windows.Forms.Label locate1Label;
        private System.Windows.Forms.Label locate2Label;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label driverNameLabel;
        private System.Windows.Forms.Label driverContactLabel;
        private System.Windows.Forms.TextBox busTextBox;
        private System.Windows.Forms.TextBox locate2TextBox;
        private System.Windows.Forms.TextBox locate1TextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox driverNameTextBox;
        private System.Windows.Forms.ComboBox busComboBox;
        private System.Windows.Forms.ComboBox locate2ComboBox;
        private System.Windows.Forms.ComboBox locate1ComboBox;
        private System.Windows.Forms.ComboBox driverNameComboBox;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView busShedulDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SAVEButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox helperNameComboBox;
        private System.Windows.Forms.TextBox helperNameTextBox;
        private System.Windows.Forms.Label helperNameLabel;
        private System.Windows.Forms.Label helperContactLabel;
        private System.Windows.Forms.TextBox contact2TextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label seatLabel;
        private System.Windows.Forms.TextBox seatTextBox;
    }
}