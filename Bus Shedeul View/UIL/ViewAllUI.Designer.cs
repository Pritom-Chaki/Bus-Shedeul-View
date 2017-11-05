namespace Bus_Shedeul_View.UIL
{
    partial class ViewAllUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shedulTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busSheduleDataSet1 = new Bus_Shedeul_View.BusSheduleDataSet1();
            this.shedulTableTableAdapter = new Bus_Shedeul_View.BusSheduleDataSet1TableAdapters.ShedulTableTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titelLabel = new System.Windows.Forms.Label();
            this.bottomLabel = new System.Windows.Forms.Label();
            this.topLeftRichTextBox = new System.Windows.Forms.RichTextBox();
            this.topRightRichTextBox = new System.Windows.Forms.RichTextBox();
            this.lebelTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.scheduleTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busSheduleDataSet2 = new Bus_Shedeul_View.BusSheduleDataSet2();
            this.scheduleTableTableAdapter = new Bus_Shedeul_View.BusSheduleDataSet2TableAdapters.ScheduleTableTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.busSheduleDataSet = new Bus_Shedeul_View.BusSheduleDataSet();
            this.shedulTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shedulTableTableAdapter1 = new Bus_Shedeul_View.BusSheduleDataSetTableAdapters.ShedulTableTableAdapter();
            this.scheduleTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfTripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helperNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helperContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shedulTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busSheduleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busSheduleDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busSheduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shedulTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // shedulTableBindingSource
            // 
            this.shedulTableBindingSource.DataMember = "ShedulTable";
            this.shedulTableBindingSource.DataSource = this.busSheduleDataSet1;
            // 
            // busSheduleDataSet1
            // 
            this.busSheduleDataSet1.DataSetName = "BusSheduleDataSet1";
            this.busSheduleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shedulTableTableAdapter
            // 
            this.shedulTableTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Bus_Shedeul_View.Properties.Resources.DIU_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(399, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 108);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelLabel.ForeColor = System.Drawing.Color.Indigo;
            this.titelLabel.Location = new System.Drawing.Point(-3, 8);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(569, 33);
            this.titelLabel.TabIndex = 6;
            this.titelLabel.Text = "TRANSPORT  SYSTEM";
            // 
            // bottomLabel
            // 
            this.bottomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomLabel.AutoSize = true;
            this.bottomLabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLabel.Location = new System.Drawing.Point(120, 623);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(106, 40);
            this.bottomLabel.TabIndex = 7;
            this.bottomLabel.Text = "label1";
            this.bottomLabel.Click += new System.EventHandler(this.bottomLabel_Click);
            // 
            // topLeftRichTextBox
            // 
            this.topLeftRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.topLeftRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topLeftRichTextBox.Enabled = false;
            this.topLeftRichTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeftRichTextBox.Location = new System.Drawing.Point(3, 76);
            this.topLeftRichTextBox.Name = "topLeftRichTextBox";
            this.topLeftRichTextBox.Size = new System.Drawing.Size(353, 151);
            this.topLeftRichTextBox.TabIndex = 8;
            this.topLeftRichTextBox.Text = "TEXT";
            // 
            // topRightRichTextBox
            // 
            this.topRightRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topRightRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.topRightRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topRightRichTextBox.Enabled = false;
            this.topRightRichTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRightRichTextBox.Location = new System.Drawing.Point(1068, 41);
            this.topRightRichTextBox.Name = "topRightRichTextBox";
            this.topRightRichTextBox.Size = new System.Drawing.Size(273, 186);
            this.topRightRichTextBox.TabIndex = 9;
            this.topRightRichTextBox.Text = "TEXT";
            // 
            // lebelTimer
            // 
            this.lebelTimer.Enabled = true;
            this.lebelTimer.Tick += new System.EventHandler(this.lebelTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Red;
            this.timeLabel.Location = new System.Drawing.Point(138, 66);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(189, 73);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "TIME";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dateLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Blue;
            this.dateLabel.Location = new System.Drawing.Point(157, 41);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(71, 33);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "DATE";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(3, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1338, 351);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeDataGridViewTextBoxColumn,
            this.startFromDataGridViewTextBoxColumn,
            this.arriveToDataGridViewTextBoxColumn,
            this.busNameDataGridViewTextBoxColumn,
            this.seatCapacityDataGridViewTextBoxColumn,
            this.typeOfTripDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.driverContactDataGridViewTextBoxColumn,
            this.helperNameDataGridViewTextBoxColumn,
            this.helperContactDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.scheduleTableBindingSource2;
            this.dataGridView2.GridColor = System.Drawing.Color.Red;
            this.dataGridView2.Location = new System.Drawing.Point(6, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(1326, 333);
            this.dataGridView2.TabIndex = 2;
            // 
            // scheduleTableBindingSource
            // 
            this.scheduleTableBindingSource.DataMember = "ScheduleTable";
            this.scheduleTableBindingSource.DataSource = this.busSheduleDataSet2;
            // 
            // busSheduleDataSet2
            // 
            this.busSheduleDataSet2.DataSetName = "BusSheduleDataSet2";
            this.busSheduleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleTableTableAdapter
            // 
            this.scheduleTableTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.titelLabel);
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Location = new System.Drawing.Point(399, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(572, 126);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // busSheduleDataSet
            // 
            this.busSheduleDataSet.DataSetName = "BusSheduleDataSet";
            this.busSheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shedulTableBindingSource1
            // 
            this.shedulTableBindingSource1.DataMember = "ShedulTable";
            this.shedulTableBindingSource1.DataSource = this.busSheduleDataSet;
            // 
            // shedulTableTableAdapter1
            // 
            this.shedulTableTableAdapter1.ClearBeforeFill = true;
            // 
            // scheduleTableBindingSource1
            // 
            this.scheduleTableBindingSource1.DataMember = "ScheduleTable";
            this.scheduleTableBindingSource1.DataSource = this.busSheduleDataSet2;
            // 
            // scheduleTableBindingSource2
            // 
            this.scheduleTableBindingSource2.DataMember = "ScheduleTable";
            this.scheduleTableBindingSource2.DataSource = this.busSheduleDataSet2;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startFromDataGridViewTextBoxColumn
            // 
            this.startFromDataGridViewTextBoxColumn.DataPropertyName = "StartFrom";
            this.startFromDataGridViewTextBoxColumn.HeaderText = "StartFrom";
            this.startFromDataGridViewTextBoxColumn.Name = "startFromDataGridViewTextBoxColumn";
            this.startFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arriveToDataGridViewTextBoxColumn
            // 
            this.arriveToDataGridViewTextBoxColumn.DataPropertyName = "ArriveTo";
            this.arriveToDataGridViewTextBoxColumn.HeaderText = "ArriveTo";
            this.arriveToDataGridViewTextBoxColumn.Name = "arriveToDataGridViewTextBoxColumn";
            this.arriveToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // busNameDataGridViewTextBoxColumn
            // 
            this.busNameDataGridViewTextBoxColumn.DataPropertyName = "BusName";
            this.busNameDataGridViewTextBoxColumn.HeaderText = "BusName";
            this.busNameDataGridViewTextBoxColumn.Name = "busNameDataGridViewTextBoxColumn";
            this.busNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seatCapacityDataGridViewTextBoxColumn
            // 
            this.seatCapacityDataGridViewTextBoxColumn.DataPropertyName = "SeatCapacity";
            this.seatCapacityDataGridViewTextBoxColumn.HeaderText = "SeatCapacity";
            this.seatCapacityDataGridViewTextBoxColumn.Name = "seatCapacityDataGridViewTextBoxColumn";
            this.seatCapacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeOfTripDataGridViewTextBoxColumn
            // 
            this.typeOfTripDataGridViewTextBoxColumn.DataPropertyName = "TypeOfTrip";
            this.typeOfTripDataGridViewTextBoxColumn.HeaderText = "TypeOfTrip";
            this.typeOfTripDataGridViewTextBoxColumn.Name = "typeOfTripDataGridViewTextBoxColumn";
            this.typeOfTripDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverContactDataGridViewTextBoxColumn
            // 
            this.driverContactDataGridViewTextBoxColumn.DataPropertyName = "DriverContact";
            this.driverContactDataGridViewTextBoxColumn.HeaderText = "DriverContact";
            this.driverContactDataGridViewTextBoxColumn.Name = "driverContactDataGridViewTextBoxColumn";
            this.driverContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // helperNameDataGridViewTextBoxColumn
            // 
            this.helperNameDataGridViewTextBoxColumn.DataPropertyName = "HelperName";
            this.helperNameDataGridViewTextBoxColumn.HeaderText = "HelperName";
            this.helperNameDataGridViewTextBoxColumn.Name = "helperNameDataGridViewTextBoxColumn";
            this.helperNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // helperContactDataGridViewTextBoxColumn
            // 
            this.helperContactDataGridViewTextBoxColumn.DataPropertyName = "HelperContact";
            this.helperContactDataGridViewTextBoxColumn.HeaderText = "HelperContact";
            this.helperContactDataGridViewTextBoxColumn.Name = "helperContactDataGridViewTextBoxColumn";
            this.helperContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewAllUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topRightRichTextBox);
            this.Controls.Add(this.topLeftRichTextBox);
            this.Controls.Add(this.bottomLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAllUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.ViewAllUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shedulTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busSheduleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busSheduleDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busSheduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shedulTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BusSheduleDataSet1 busSheduleDataSet1;
        private System.Windows.Forms.BindingSource shedulTableBindingSource;
        private BusSheduleDataSet1TableAdapters.ShedulTableTableAdapter shedulTableTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.Label bottomLabel;
        private System.Windows.Forms.RichTextBox topLeftRichTextBox;
        private System.Windows.Forms.RichTextBox topRightRichTextBox;
        private System.Windows.Forms.Timer lebelTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BusSheduleDataSet2 busSheduleDataSet2;
        private System.Windows.Forms.BindingSource scheduleTableBindingSource;
        private BusSheduleDataSet2TableAdapters.ScheduleTableTableAdapter scheduleTableTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private BusSheduleDataSet busSheduleDataSet;
        private System.Windows.Forms.BindingSource shedulTableBindingSource1;
        private BusSheduleDataSetTableAdapters.ShedulTableTableAdapter shedulTableTableAdapter1;
        private System.Windows.Forms.BindingSource scheduleTableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfTripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn helperNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn helperContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource scheduleTableBindingSource2;
    }
}