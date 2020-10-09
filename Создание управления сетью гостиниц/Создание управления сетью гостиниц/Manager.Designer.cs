namespace Создание_управления_сетью_гостиниц
{
    partial class Manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Changer = new System.Windows.Forms.Button();
            this.Saver = new System.Windows.Forms.Button();
            this.InsertAdmin = new System.Windows.Forms.Button();
            this.RegAdmin = new System.Windows.Forms.Button();
            this.DeleteAdmin = new System.Windows.Forms.Button();
            this.SelectHosts = new System.Windows.Forms.Button();
            this.CancelHosts = new System.Windows.Forms.Button();
            this.SelectAdmins = new System.Windows.Forms.Button();
            this.CancelAdmins = new System.Windows.Forms.Button();
            this.BlockAdmin = new System.Windows.Forms.Button();
            this.adminListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new Создание_управления_сетью_гостиниц.DataBaseDataSet();
            this.adminListTableAdapter = new Создание_управления_сетью_гостиниц.DataBaseDataSetTableAdapters.AdminListTableAdapter();
            this.dataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IncrementADG = new System.Windows.Forms.Button();
            this.EditionADG = new System.Windows.Forms.Button();
            this.DeleteADG = new System.Windows.Forms.Button();
            this.advancedDataGridView2 = new Zuby.ADGV.AdvancedDataGridView();
            this.isCheckedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.номерГостиницыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоЭтажейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНомеровDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.улицаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet5 = new Создание_управления_сетью_гостиниц.DataBaseDataSet5();
            this.hostsTableAdapter = new Создание_управления_сетью_гостиниц.DataBaseDataSet5TableAdapters.HostsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView2.Location = new System.Drawing.Point(12, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Size = new System.Drawing.Size(668, 205);
            this.dataGridView2.TabIndex = 5;
            // 
            // Changer
            // 
            this.Changer.BackColor = System.Drawing.Color.Gold;
            this.Changer.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Changer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Changer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Changer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Changer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Changer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Changer.ForeColor = System.Drawing.Color.Maroon;
            this.Changer.Location = new System.Drawing.Point(12, 37);
            this.Changer.Name = "Changer";
            this.Changer.Size = new System.Drawing.Size(143, 41);
            this.Changer.TabIndex = 6;
            this.Changer.Text = "Импортировать Администраторов";
            this.Changer.UseVisualStyleBackColor = false;
            this.Changer.Click += new System.EventHandler(this.Changer_Click);
            // 
            // Saver
            // 
            this.Saver.BackColor = System.Drawing.Color.Gold;
            this.Saver.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Saver.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Saver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Saver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Saver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Saver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Saver.ForeColor = System.Drawing.Color.Maroon;
            this.Saver.Location = new System.Drawing.Point(161, 37);
            this.Saver.Name = "Saver";
            this.Saver.Size = new System.Drawing.Size(137, 41);
            this.Saver.TabIndex = 7;
            this.Saver.Text = "Экспортировать в Excel Таблицу";
            this.Saver.UseVisualStyleBackColor = false;
            this.Saver.Click += new System.EventHandler(this.Saver_Click);
            // 
            // InsertAdmin
            // 
            this.InsertAdmin.BackColor = System.Drawing.Color.Gold;
            this.InsertAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.InsertAdmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.InsertAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InsertAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InsertAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertAdmin.ForeColor = System.Drawing.Color.Maroon;
            this.InsertAdmin.Location = new System.Drawing.Point(686, 84);
            this.InsertAdmin.Name = "InsertAdmin";
            this.InsertAdmin.Size = new System.Drawing.Size(184, 23);
            this.InsertAdmin.TabIndex = 19;
            this.InsertAdmin.Text = "Добавить Администратора";
            this.InsertAdmin.UseVisualStyleBackColor = false;
            this.InsertAdmin.Click += new System.EventHandler(this.InsertAdmin_Click);
            // 
            // RegAdmin
            // 
            this.RegAdmin.BackColor = System.Drawing.Color.Gold;
            this.RegAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.RegAdmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.RegAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RegAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RegAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegAdmin.ForeColor = System.Drawing.Color.Maroon;
            this.RegAdmin.Location = new System.Drawing.Point(686, 113);
            this.RegAdmin.Name = "RegAdmin";
            this.RegAdmin.Size = new System.Drawing.Size(184, 23);
            this.RegAdmin.TabIndex = 20;
            this.RegAdmin.Text = "Редактировать Администратора";
            this.RegAdmin.UseVisualStyleBackColor = false;
            this.RegAdmin.Click += new System.EventHandler(this.RegAdmin_Click);
            // 
            // DeleteAdmin
            // 
            this.DeleteAdmin.BackColor = System.Drawing.Color.Gold;
            this.DeleteAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.DeleteAdmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.DeleteAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeleteAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeleteAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAdmin.ForeColor = System.Drawing.Color.Maroon;
            this.DeleteAdmin.Location = new System.Drawing.Point(686, 171);
            this.DeleteAdmin.Name = "DeleteAdmin";
            this.DeleteAdmin.Size = new System.Drawing.Size(184, 23);
            this.DeleteAdmin.TabIndex = 21;
            this.DeleteAdmin.Text = "Удалить Администратора/ов";
            this.DeleteAdmin.UseVisualStyleBackColor = false;
            this.DeleteAdmin.Click += new System.EventHandler(this.DeleteAdmin_Click);
            // 
            // SelectHosts
            // 
            this.SelectHosts.BackColor = System.Drawing.Color.Gold;
            this.SelectHosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectHosts.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.SelectHosts.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.SelectHosts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SelectHosts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SelectHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectHosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectHosts.ForeColor = System.Drawing.Color.Maroon;
            this.SelectHosts.Location = new System.Drawing.Point(686, 444);
            this.SelectHosts.Name = "SelectHosts";
            this.SelectHosts.Size = new System.Drawing.Size(184, 23);
            this.SelectHosts.TabIndex = 23;
            this.SelectHosts.Text = "Выбрать все";
            this.SelectHosts.UseVisualStyleBackColor = false;
            this.SelectHosts.Click += new System.EventHandler(this.SelectHosts_Click);
            // 
            // CancelHosts
            // 
            this.CancelHosts.BackColor = System.Drawing.Color.Gold;
            this.CancelHosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelHosts.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.CancelHosts.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.CancelHosts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CancelHosts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CancelHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelHosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelHosts.ForeColor = System.Drawing.Color.Maroon;
            this.CancelHosts.Location = new System.Drawing.Point(686, 473);
            this.CancelHosts.Name = "CancelHosts";
            this.CancelHosts.Size = new System.Drawing.Size(184, 23);
            this.CancelHosts.TabIndex = 24;
            this.CancelHosts.Text = "Отменить все";
            this.CancelHosts.UseVisualStyleBackColor = false;
            this.CancelHosts.Click += new System.EventHandler(this.CancelHosts_Click);
            // 
            // SelectAdmins
            // 
            this.SelectAdmins.BackColor = System.Drawing.Color.Gold;
            this.SelectAdmins.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.SelectAdmins.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.SelectAdmins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SelectAdmins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SelectAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectAdmins.ForeColor = System.Drawing.Color.Maroon;
            this.SelectAdmins.Location = new System.Drawing.Point(686, 200);
            this.SelectAdmins.Name = "SelectAdmins";
            this.SelectAdmins.Size = new System.Drawing.Size(184, 23);
            this.SelectAdmins.TabIndex = 25;
            this.SelectAdmins.Text = "Выбрать все";
            this.SelectAdmins.UseVisualStyleBackColor = false;
            this.SelectAdmins.Click += new System.EventHandler(this.SelectAdmins_Click);
            // 
            // CancelAdmins
            // 
            this.CancelAdmins.BackColor = System.Drawing.Color.Gold;
            this.CancelAdmins.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.CancelAdmins.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.CancelAdmins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CancelAdmins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CancelAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelAdmins.ForeColor = System.Drawing.Color.Maroon;
            this.CancelAdmins.Location = new System.Drawing.Point(686, 229);
            this.CancelAdmins.Name = "CancelAdmins";
            this.CancelAdmins.Size = new System.Drawing.Size(184, 23);
            this.CancelAdmins.TabIndex = 26;
            this.CancelAdmins.Text = "Отменить все";
            this.CancelAdmins.UseVisualStyleBackColor = false;
            this.CancelAdmins.Click += new System.EventHandler(this.CancelAdmins_Click);
            // 
            // BlockAdmin
            // 
            this.BlockAdmin.BackColor = System.Drawing.Color.Gold;
            this.BlockAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BlockAdmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.BlockAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BlockAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BlockAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlockAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockAdmin.ForeColor = System.Drawing.Color.Maroon;
            this.BlockAdmin.Location = new System.Drawing.Point(686, 142);
            this.BlockAdmin.Name = "BlockAdmin";
            this.BlockAdmin.Size = new System.Drawing.Size(184, 23);
            this.BlockAdmin.TabIndex = 28;
            this.BlockAdmin.Text = "Заблокировать";
            this.BlockAdmin.UseVisualStyleBackColor = false;
            this.BlockAdmin.Click += new System.EventHandler(this.BlockAdmin_Click);
            // 
            // adminListBindingSource
            // 
            this.adminListBindingSource.DataMember = "AdminList";
            this.adminListBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminListTableAdapter
            // 
            this.adminListTableAdapter.ClearBeforeFill = true;
            // 
            // dataBaseDataSetBindingSource
            // 
            this.dataBaseDataSetBindingSource.DataSource = this.dataBaseDataSet;
            this.dataBaseDataSetBindingSource.Position = 0;
            // 
            // IncrementADG
            // 
            this.IncrementADG.BackColor = System.Drawing.Color.Gold;
            this.IncrementADG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IncrementADG.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.IncrementADG.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.IncrementADG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IncrementADG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IncrementADG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncrementADG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncrementADG.ForeColor = System.Drawing.Color.Maroon;
            this.IncrementADG.Location = new System.Drawing.Point(686, 355);
            this.IncrementADG.Name = "IncrementADG";
            this.IncrementADG.Size = new System.Drawing.Size(184, 23);
            this.IncrementADG.TabIndex = 30;
            this.IncrementADG.Text = "Добавить";
            this.IncrementADG.UseVisualStyleBackColor = false;
            this.IncrementADG.Click += new System.EventHandler(this.IncrementADG_Click);
            // 
            // EditionADG
            // 
            this.EditionADG.BackColor = System.Drawing.Color.Gold;
            this.EditionADG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditionADG.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.EditionADG.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.EditionADG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EditionADG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EditionADG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditionADG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditionADG.ForeColor = System.Drawing.Color.Maroon;
            this.EditionADG.Location = new System.Drawing.Point(686, 384);
            this.EditionADG.Name = "EditionADG";
            this.EditionADG.Size = new System.Drawing.Size(184, 23);
            this.EditionADG.TabIndex = 31;
            this.EditionADG.Text = "редактировать";
            this.EditionADG.UseVisualStyleBackColor = false;
            this.EditionADG.Click += new System.EventHandler(this.EditionADG_Click);
            // 
            // DeleteADG
            // 
            this.DeleteADG.BackColor = System.Drawing.Color.Gold;
            this.DeleteADG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteADG.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.DeleteADG.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.DeleteADG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeleteADG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeleteADG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteADG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteADG.ForeColor = System.Drawing.Color.Maroon;
            this.DeleteADG.Location = new System.Drawing.Point(686, 413);
            this.DeleteADG.Name = "DeleteADG";
            this.DeleteADG.Size = new System.Drawing.Size(184, 23);
            this.DeleteADG.TabIndex = 32;
            this.DeleteADG.Text = "Удалить";
            this.DeleteADG.UseVisualStyleBackColor = false;
            this.DeleteADG.Click += new System.EventHandler(this.DeleteADG_Click);
            // 
            // advancedDataGridView2
            // 
            this.advancedDataGridView2.AllowUserToAddRows = false;
            this.advancedDataGridView2.AllowUserToDeleteRows = false;
            this.advancedDataGridView2.AutoGenerateColumns = false;
            this.advancedDataGridView2.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.advancedDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isCheckedDataGridViewCheckBoxColumn,
            this.номерГостиницыDataGridViewTextBoxColumn,
            this.количествоЭтажейDataGridViewTextBoxColumn,
            this.количествоНомеровDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.улицаDataGridViewTextBoxColumn,
            this.домDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.advancedDataGridView2.DataSource = this.hostsBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView2.DefaultCellStyle = dataGridViewCellStyle7;
            this.advancedDataGridView2.EnableHeadersVisualStyles = false;
            this.advancedDataGridView2.FilterAndSortEnabled = true;
            this.advancedDataGridView2.GridColor = System.Drawing.Color.IndianRed;
            this.advancedDataGridView2.Location = new System.Drawing.Point(12, 346);
            this.advancedDataGridView2.Name = "advancedDataGridView2";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.advancedDataGridView2.Size = new System.Drawing.Size(668, 150);
            this.advancedDataGridView2.TabIndex = 33;
            // 
            // isCheckedDataGridViewCheckBoxColumn
            // 
            this.isCheckedDataGridViewCheckBoxColumn.DataPropertyName = "IsChecked";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.NullValue = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Maroon;
            this.isCheckedDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.isCheckedDataGridViewCheckBoxColumn.HeaderText = "IsChecked";
            this.isCheckedDataGridViewCheckBoxColumn.MinimumWidth = 22;
            this.isCheckedDataGridViewCheckBoxColumn.Name = "isCheckedDataGridViewCheckBoxColumn";
            this.isCheckedDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // номерГостиницыDataGridViewTextBoxColumn
            // 
            this.номерГостиницыDataGridViewTextBoxColumn.DataPropertyName = "Номер гостиницы";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Maroon;
            this.номерГостиницыDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.номерГостиницыDataGridViewTextBoxColumn.HeaderText = "Номер гостиницы";
            this.номерГостиницыDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.номерГостиницыDataGridViewTextBoxColumn.Name = "номерГостиницыDataGridViewTextBoxColumn";
            this.номерГостиницыDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // количествоЭтажейDataGridViewTextBoxColumn
            // 
            this.количествоЭтажейDataGridViewTextBoxColumn.DataPropertyName = "Количество этажей";
            this.количествоЭтажейDataGridViewTextBoxColumn.HeaderText = "Количество этажей";
            this.количествоЭтажейDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.количествоЭтажейDataGridViewTextBoxColumn.Name = "количествоЭтажейDataGridViewTextBoxColumn";
            this.количествоЭтажейDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // количествоНомеровDataGridViewTextBoxColumn
            // 
            this.количествоНомеровDataGridViewTextBoxColumn.DataPropertyName = "Количество номеров";
            this.количествоНомеровDataGridViewTextBoxColumn.HeaderText = "Количество номеров";
            this.количествоНомеровDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.количествоНомеровDataGridViewTextBoxColumn.Name = "количествоНомеровDataGridViewTextBoxColumn";
            this.количествоНомеровDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            this.странаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            this.городDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // улицаDataGridViewTextBoxColumn
            // 
            this.улицаDataGridViewTextBoxColumn.DataPropertyName = "Улица";
            this.улицаDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.улицаDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.улицаDataGridViewTextBoxColumn.Name = "улицаDataGridViewTextBoxColumn";
            this.улицаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // домDataGridViewTextBoxColumn
            // 
            this.домDataGridViewTextBoxColumn.DataPropertyName = "Дом";
            this.домDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.домDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.домDataGridViewTextBoxColumn.Name = "домDataGridViewTextBoxColumn";
            this.домDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // hostsBindingSource
            // 
            this.hostsBindingSource.DataMember = "Hosts";
            this.hostsBindingSource.DataSource = this.dataBaseDataSet5;
            // 
            // dataBaseDataSet5
            // 
            this.dataBaseDataSet5.DataSetName = "DataBaseDataSet5";
            this.dataBaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hostsTableAdapter
            // 
            this.hostsTableAdapter.ClearBeforeFill = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(929, 531);
            this.Controls.Add(this.advancedDataGridView2);
            this.Controls.Add(this.DeleteADG);
            this.Controls.Add(this.EditionADG);
            this.Controls.Add(this.IncrementADG);
            this.Controls.Add(this.BlockAdmin);
            this.Controls.Add(this.CancelAdmins);
            this.Controls.Add(this.SelectAdmins);
            this.Controls.Add(this.CancelHosts);
            this.Controls.Add(this.SelectHosts);
            this.Controls.Add(this.DeleteAdmin);
            this.Controls.Add(this.RegAdmin);
            this.Controls.Add(this.InsertAdmin);
            this.Controls.Add(this.Saver);
            this.Controls.Add(this.Changer);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.Text = "Управляющий";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manager_FormClosed);
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource adminListBindingSource;
        private DataBaseDataSetTableAdapters.AdminListTableAdapter adminListTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Changer;
        private System.Windows.Forms.Button Saver;
        private System.Windows.Forms.BindingSource dataBaseDataSetBindingSource;
        private System.Windows.Forms.Button InsertAdmin;
        private System.Windows.Forms.Button RegAdmin;
        private System.Windows.Forms.Button DeleteAdmin;
        private System.Windows.Forms.Button SelectHosts;
        private System.Windows.Forms.Button CancelHosts;
        private System.Windows.Forms.Button SelectAdmins;
        private System.Windows.Forms.Button CancelAdmins;
        private System.Windows.Forms.Button BlockAdmin;
        private System.Windows.Forms.Button IncrementADG;
        private System.Windows.Forms.Button EditionADG;
        private System.Windows.Forms.Button DeleteADG;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView2;
        private DataBaseDataSet5 dataBaseDataSet5;
        private System.Windows.Forms.BindingSource hostsBindingSource;
        private DataBaseDataSet5TableAdapters.HostsTableAdapter hostsTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCheckedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерГостиницыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоЭтажейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоНомеровDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn улицаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}