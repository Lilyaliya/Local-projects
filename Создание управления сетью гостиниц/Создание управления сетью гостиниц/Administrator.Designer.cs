namespace Создание_управления_сетью_гостиниц
{
    partial class Administrator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.GridGuests = new System.Windows.Forms.DataGridView();
            this.Change = new System.Windows.Forms.Button();
            this.Insertion = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.SelectAll = new System.Windows.Forms.Button();
            this.CancelAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridHostel = new System.Windows.Forms.DataGridView();
            this.EditHostel = new System.Windows.Forms.Button();
            this.Inserthostel = new System.Windows.Forms.Button();
            this.deleteHostel = new System.Windows.Forms.Button();
            this.Select1 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.CheckIn = new System.Windows.Forms.Button();
            this.CheckOut = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HostelAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHostel)).BeginInit();
            this.SuspendLayout();
            // 
            // GridGuests
            // 
            this.GridGuests.AllowUserToAddRows = false;
            this.GridGuests.AllowUserToDeleteRows = false;
            this.GridGuests.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridGuests.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridGuests.EnableHeadersVisualStyles = false;
            this.GridGuests.GridColor = System.Drawing.Color.DarkGreen;
            this.GridGuests.Location = new System.Drawing.Point(44, 76);
            this.GridGuests.Name = "GridGuests";
            this.GridGuests.ReadOnly = true;
            this.GridGuests.Size = new System.Drawing.Size(648, 200);
            this.GridGuests.TabIndex = 0;
            this.GridGuests.VirtualMode = true;
            this.GridGuests.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridGuests_ColumnHeaderMouseClick);
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.LightGreen;
            this.Change.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Change.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Change.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.ForeColor = System.Drawing.Color.DarkGreen;
            this.Change.Location = new System.Drawing.Point(698, 76);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(167, 23);
            this.Change.TabIndex = 2;
            this.Change.Text = "Редактировать";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Insertion
            // 
            this.Insertion.BackColor = System.Drawing.Color.LightGreen;
            this.Insertion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Insertion.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Insertion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Insertion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Insertion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Insertion.ForeColor = System.Drawing.Color.DarkGreen;
            this.Insertion.Location = new System.Drawing.Point(698, 122);
            this.Insertion.Name = "Insertion";
            this.Insertion.Size = new System.Drawing.Size(167, 23);
            this.Insertion.TabIndex = 3;
            this.Insertion.Text = "Добавить запись";
            this.Insertion.UseVisualStyleBackColor = false;
            this.Insertion.Click += new System.EventHandler(this.Insertion_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.LightGreen;
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.Color.DarkGreen;
            this.Delete.Location = new System.Drawing.Point(698, 164);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(167, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Удалить запись/записи";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Export
            // 
            this.Export.BackColor = System.Drawing.Color.LightGreen;
            this.Export.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Export.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Export.ForeColor = System.Drawing.Color.DarkGreen;
            this.Export.Location = new System.Drawing.Point(698, 208);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(167, 23);
            this.Export.TabIndex = 5;
            this.Export.Text = "Выгрузить в CSV";
            this.Export.UseVisualStyleBackColor = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.BackColor = System.Drawing.Color.LightGreen;
            this.SelectAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SelectAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SelectAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.SelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectAll.ForeColor = System.Drawing.Color.DarkGreen;
            this.SelectAll.Location = new System.Drawing.Point(44, 289);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(93, 23);
            this.SelectAll.TabIndex = 6;
            this.SelectAll.Text = "Выделить все";
            this.SelectAll.UseVisualStyleBackColor = false;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // CancelAll
            // 
            this.CancelAll.BackColor = System.Drawing.Color.LightGreen;
            this.CancelAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CancelAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CancelAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.CancelAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.CancelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelAll.ForeColor = System.Drawing.Color.DarkGreen;
            this.CancelAll.Location = new System.Drawing.Point(155, 289);
            this.CancelAll.Name = "CancelAll";
            this.CancelAll.Size = new System.Drawing.Size(95, 23);
            this.CancelAll.TabIndex = 7;
            this.CancelAll.Text = "Отменить все";
            this.CancelAll.UseVisualStyleBackColor = false;
            this.CancelAll.Click += new System.EventHandler(this.CancelAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Постояльцы гостиницы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(41, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Номера гостиницы";
            // 
            // GridHostel
            // 
            this.GridHostel.AllowUserToAddRows = false;
            this.GridHostel.AllowUserToDeleteRows = false;
            this.GridHostel.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridHostel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridHostel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridHostel.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridHostel.EnableHeadersVisualStyles = false;
            this.GridHostel.GridColor = System.Drawing.Color.DarkGreen;
            this.GridHostel.Location = new System.Drawing.Point(44, 405);
            this.GridHostel.Name = "GridHostel";
            this.GridHostel.ReadOnly = true;
            this.GridHostel.Size = new System.Drawing.Size(429, 150);
            this.GridHostel.TabIndex = 10;
            // 
            // EditHostel
            // 
            this.EditHostel.BackColor = System.Drawing.Color.LightGreen;
            this.EditHostel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.EditHostel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.EditHostel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.EditHostel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.EditHostel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditHostel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditHostel.ForeColor = System.Drawing.Color.DarkGreen;
            this.EditHostel.Location = new System.Drawing.Point(479, 405);
            this.EditHostel.Name = "EditHostel";
            this.EditHostel.Size = new System.Drawing.Size(167, 23);
            this.EditHostel.TabIndex = 11;
            this.EditHostel.Text = "Редактировать";
            this.EditHostel.UseVisualStyleBackColor = false;
            this.EditHostel.Click += new System.EventHandler(this.EditHostel_Click);
            // 
            // Inserthostel
            // 
            this.Inserthostel.BackColor = System.Drawing.Color.LightGreen;
            this.Inserthostel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Inserthostel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Inserthostel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Inserthostel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Inserthostel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inserthostel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inserthostel.ForeColor = System.Drawing.Color.DarkGreen;
            this.Inserthostel.Location = new System.Drawing.Point(479, 448);
            this.Inserthostel.Name = "Inserthostel";
            this.Inserthostel.Size = new System.Drawing.Size(167, 23);
            this.Inserthostel.TabIndex = 12;
            this.Inserthostel.Text = "Добавить";
            this.Inserthostel.UseVisualStyleBackColor = false;
            this.Inserthostel.Click += new System.EventHandler(this.Inserthostel_Click);
            // 
            // deleteHostel
            // 
            this.deleteHostel.BackColor = System.Drawing.Color.LightGreen;
            this.deleteHostel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.deleteHostel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.deleteHostel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.deleteHostel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.deleteHostel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteHostel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteHostel.ForeColor = System.Drawing.Color.DarkGreen;
            this.deleteHostel.Location = new System.Drawing.Point(479, 493);
            this.deleteHostel.Name = "deleteHostel";
            this.deleteHostel.Size = new System.Drawing.Size(167, 23);
            this.deleteHostel.TabIndex = 13;
            this.deleteHostel.Text = "Удалить";
            this.deleteHostel.UseVisualStyleBackColor = false;
            this.deleteHostel.Click += new System.EventHandler(this.deleteHostel_Click);
            // 
            // Select1
            // 
            this.Select1.BackColor = System.Drawing.Color.LightGreen;
            this.Select1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Select1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Select1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Select1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Select1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select1.ForeColor = System.Drawing.Color.DarkGreen;
            this.Select1.Location = new System.Drawing.Point(45, 561);
            this.Select1.Name = "Select1";
            this.Select1.Size = new System.Drawing.Size(104, 23);
            this.Select1.TabIndex = 14;
            this.Select1.Text = "Выбрать все ";
            this.Select1.UseVisualStyleBackColor = false;
            this.Select1.Click += new System.EventHandler(this.Select1_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.LightGreen;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.ForeColor = System.Drawing.Color.DarkGreen;
            this.Cancel.Location = new System.Drawing.Point(155, 561);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(95, 23);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Отменить все";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CheckIn
            // 
            this.CheckIn.BackColor = System.Drawing.Color.LightGreen;
            this.CheckIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CheckIn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CheckIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.CheckIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckIn.ForeColor = System.Drawing.Color.DarkGreen;
            this.CheckIn.Location = new System.Drawing.Point(698, 253);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(167, 23);
            this.CheckIn.TabIndex = 16;
            this.CheckIn.Text = "Заселить постояльца/ев";
            this.CheckIn.UseVisualStyleBackColor = false;
            this.CheckIn.Click += new System.EventHandler(this.CheckIn_Click);
            // 
            // CheckOut
            // 
            this.CheckOut.BackColor = System.Drawing.Color.LightGreen;
            this.CheckOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CheckOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CheckOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.CheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckOut.ForeColor = System.Drawing.Color.DarkGreen;
            this.CheckOut.Location = new System.Drawing.Point(698, 289);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(167, 23);
            this.CheckOut.TabIndex = 17;
            this.CheckOut.Text = "Выселить постояльца/ев ";
            this.CheckOut.UseVisualStyleBackColor = false;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admin.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Admin.Location = new System.Drawing.Point(41, 16);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(57, 20);
            this.Admin.TabIndex = 18;
            this.Admin.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(359, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Гостиница";
            // 
            // HostelAd
            // 
            this.HostelAd.AutoSize = true;
            this.HostelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HostelAd.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.HostelAd.Location = new System.Drawing.Point(463, 9);
            this.HostelAd.Name = "HostelAd";
            this.HostelAd.Size = new System.Drawing.Size(57, 20);
            this.HostelAd.TabIndex = 20;
            this.HostelAd.Text = "label3";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(886, 643);
            this.Controls.Add(this.HostelAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.CheckIn);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Select1);
            this.Controls.Add(this.deleteHostel);
            this.Controls.Add(this.Inserthostel);
            this.Controls.Add(this.EditHostel);
            this.Controls.Add(this.GridHostel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelAll);
            this.Controls.Add(this.SelectAll);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insertion);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.GridGuests);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrator";
            this.Text = "Администратор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrator_FormClosed);
            this.Load += new System.EventHandler(this.Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHostel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView GridGuests;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Insertion;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button SelectAll;
        private System.Windows.Forms.Button CancelAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView GridHostel;
        private System.Windows.Forms.Button EditHostel;
        private System.Windows.Forms.Button Inserthostel;
        private System.Windows.Forms.Button deleteHostel;
        private System.Windows.Forms.Button Select1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button CheckIn;
        private System.Windows.Forms.Button CheckOut;
        public System.Windows.Forms.Label Admin;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label HostelAd;
    }
}