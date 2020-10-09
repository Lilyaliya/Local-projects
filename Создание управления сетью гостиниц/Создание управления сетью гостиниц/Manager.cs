using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using ExcelObj = Microsoft.Office.Interop.Excel;

namespace Создание_управления_сетью_гостиниц
{
    public partial class Manager : Form
    {
        public string CmdText = "SELECT*FROM Admins";
        public string CmdText1 = "Select*From[Hosts] order by ID";
        public string ExcelConnStr;
        public string direct;
        public DataTable ExcelSet;
        public string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Mode=ReadWrite;Persist Security Info=True;User ID=Admin;Data Source=";
        //Extended Properties=[Excel 8.0;HDR=Yes;\;
        //C:\Users\user\source\repos\Создание управления сетью гостиниц\Admins.xlsx;

        public Manager()
        {
            direct = @Directory.GetCurrentDirectory();
            ConnectionString += direct + @"\\DataBase.accdb";
            InitializeComponent();
            ShowAdmins();
            ShowHosts_Click();
            //GridHosts.DataSource = dataSet.Tables[1].DefaultView;
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //private void Manager_Load(object sender, EventArgs e)
        //{

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.AdminList". При необходимости она может быть перемещена или удалена.
          //  this.adminListTableAdapter.Fill(this.dataBaseDataSet.AdminList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.AdminList". При необходимости она может быть перемещена или удалена.
            // this.adminListTableAdapter.Fill(this.dataBaseDataSet.AdminList);

        //}

        private void Insert_Click(object sender, EventArgs e)
        {
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string cmd_text;
            EditionInsertion editionInsertion = new EditionInsertion();
            int index;
            string CurrentAdmin;

            index = dataGridView2.CurrentRow.Index;
            CurrentAdmin = Convert.ToString(dataGridView2[0, index].Value);

            editionInsertion.textBox1.Text = CurrentAdmin;
            editionInsertion.textBox2.Text = Convert.ToString(dataGridView2[1,index].Value);
            editionInsertion.textBox3.Text = Convert.ToString(dataGridView2[2, index].Value);
            editionInsertion.textBox4.Text = Convert.ToString(dataGridView2[3, index].Value);
            editionInsertion.textBox5.Text = Convert.ToString(dataGridView2[4, index].Value);
            editionInsertion.textBox6.Text = Convert.ToString(dataGridView2[5, index].Value);
            editionInsertion.textBox7.Text = Convert.ToString(dataGridView2[6, index].Value);

            if (editionInsertion.ShowDialog() == DialogResult.OK)
            {
                cmd_text = "UPDATE [AdminList] SET [Логин] = '" + editionInsertion.textBox1.Text + "', " +
                "[Пароль] = '" + editionInsertion.textBox2.Text + "', " +
                "[Фамилия] = '" + editionInsertion.textBox3.Text + "', " +
                "[Имя] = '" + editionInsertion.textBox4.Text + "', " +
                "[Отчество] = '" + editionInsertion.textBox5.Text + "', " +
                "[Номер телефона] = '" + editionInsertion.textBox6.Text + "', " +
                "[Гостиница] = '" + editionInsertion.textBox7.Text +"' "+
                "WHERE [Логин] = '" + CurrentAdmin + "'";

                OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                sql_conn.ResetState();
                // создать команду на языке SQL
                OleDbCommand sql_comm = new OleDbCommand(cmd_text, sql_conn);

                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();

                this.adminListTableAdapter.Fill(this.dataBaseDataSet.AdminList);
            }
        }

        private void Changer_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog=new OpenFileDialog())
            {
                fileDialog.Title = "Импортирование Excel файла";
                fileDialog.Filter = "Excel Workbook(*.xls;*.xlsx)|*.xlsx;*.xls";
                if (fileDialog.ShowDialog()==DialogResult.OK)
                {
                    GetConnStr( fileDialog.FileName);
                    OleDbConnection dbase = new OleDbConnection(ExcelConnStr);
                    OleDbConnection connection = new OleDbConnection(ConnectionString);
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From [Лист1$]", dbase);
                    //ExcelSet = new DataTable();
                    //oleDbDataAdapter.Fill(ExcelSet);
                    //dataGridView2.DataSource = ExcelSet;
                    dbase.Open(); // открыть соединение
                                  // создать команду на языке 
                    //connection.Open();
                    string Command = @"Insert Into [MS Access;Database="+ direct + @"\\DataBase.accdb" + ";].[Admins] Select*From [Лист1$]";
                    OleDbCommand sql_comm = new OleDbCommand(Command, dbase);
                    sql_comm.ExecuteNonQuery(); // выполнить команду на языке SQL
                    dbase.Close();
                    //connection.Close();
                    ShowAdmins();
                }
            }

            
        }

        private void Saver_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook(*.xls;*.xlsx)|*.xlsx;*.xls"})
            {
                
                if (saveFileDialog.ShowDialog()==DialogResult.OK)
                {
                    path = saveFileDialog.FileName;
                    ExcelObj.Application application = new ExcelObj.Application();
                   // application.GetOpenFilename(path);
                    ExcelObj.Workbook workbook = application.Workbooks.Open(saveFileDialog.FileName);
                    application.Visible = false;
                    ExcelObj.Worksheet worksheet = (ExcelObj.Worksheet)workbook.Sheets[1];
                    worksheet.Cells[1, 1] = "Логин";
                    worksheet.Cells[1, 2] = "Пароль";
                    worksheet.Cells[1, 3] = "Фамилия";
                    worksheet.Cells[1, 4] = "Имя";
                    worksheet.Cells[1, 5] = "Отчество";
                    worksheet.Cells[1, 6] = "Номер телефона";
                    worksheet.Cells[1, 7] = "Гостиница";
                    for (int i = 2; i <= dataGridView2.RowCount; i++)
                    {
                        for (int j = 1; j <= dataGridView2.ColumnCount; j++)
                        {
                            worksheet.Cells[i,j] = dataGridView2.Rows[i-2].Cells[j-1].Value;
                        }
                    }

                    //application.AlertBeforeOverwriting = false;
                    worksheet.SaveAs(saveFileDialog.FileName,Type.Missing, Type.Missing, Type.Missing, false, false, ExcelObj.XlSaveAsAccessMode.xlNoChange, ExcelObj.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    application.Quit();

                }
            }


        }
        public string path;
        //public string path = @"C:\Users\user\source\repos\Создание управления сетью гостиниц\";
        public void SaveTable()
        {
            string path = @"C:\Users\user\source\repos\Создание управления сетью гостиниц\Admins.xlsx";
            ExcelObj.Application application = new ExcelObj.Application();
            ExcelObj.Workbook workbook = application.Workbooks.Add();
            ExcelObj.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 1; i <= dataGridView2.RowCount - 1; i++)
            {
                for (int j = 0; j <= dataGridView2.ColumnCount - 1; j++)
                {
                    worksheet.Rows[i].Columns[j] = dataGridView2.Rows[i].Cells[j].Value;
                }
            }

            application.AlertBeforeOverwriting = false;
            workbook.SaveAs(path);
            application.Quit();
        }

       

        public void ShowHosts_Click()
        {
            
            advancedDataGridView2.Columns[8].Visible = false;
            advancedDataGridView2.RowHeadersVisible = false;
            advancedDataGridView2.ReadOnly = false;
            foreach (DataGridViewColumn column in advancedDataGridView2.Columns)
                column.ReadOnly = true;
            advancedDataGridView2.Columns[0].ReadOnly = false;
            advancedDataGridView2.Columns[0].Width = 30;
            advancedDataGridView2.Columns[0].HeaderText = "";
        }

        public void GetConnStr(string fileName)
        {
            ExcelConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=Excel 12.0;";
        }

        private void InsertAdmin_Click(object sender, EventArgs e)
        {
            string cmd_text;
            EditionInsertion editionInsertion = new EditionInsertion();
            //EditionInsertion editionInsertion = new EditionInsertion();
            if (editionInsertion.ShowDialog() == DialogResult.OK)
            {
                cmd_text = "INSERT INTO Admins (Логин, Пароль, Фамилия, Имя, Отчество, [Номер телефона], Гостиница) VALUES (" +
                "'" + editionInsertion.textBox1.Text + "' , '" +
                editionInsertion.textBox2.Text + "' , '" +
                editionInsertion.textBox3.Text + "' , '" +
                editionInsertion.textBox4.Text + "', '" +
                editionInsertion.textBox5.Text + "', '" +
                editionInsertion.textBox6.Text + "', '" +
                editionInsertion.textBox7.Text + "')";

                // создать соединение с базой данных
                OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                sql_conn.Open(); // открыть соединение
                                 // создать команду на языке 

                OleDbCommand sql_comm = new OleDbCommand(cmd_text, sql_conn);
                sql_comm.ExecuteNonQuery(); // выполнить команду на языке SQL
                sql_conn.Close(); // закрыть соединение
                ShowAdmins();
                editionInsertion.Close();
                //this.adminListTableAdapter.Fill(this.dataBaseDataSet.AdminList);
            }
        }

        public void ShowAdmins()
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select*From Admins", ConnectionString);
            //DataSet set = new DataSet();
            DataSet dataSet = new DataSet();
            int count=dataAdapter.Fill(dataSet);
            if (count!=0)
            {
                Changer.Enabled = false;
            }
            dataGridView2.DataSource = dataSet.Tables[0].DefaultView;

            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ReadOnly = false;
            dataGridView2.MultiSelect = true;
            foreach (DataGridViewColumn column in dataGridView2.Columns)
                column.ReadOnly = true;
            dataGridView2.Columns[7].DisplayIndex = 0;
            dataGridView2.Columns[7].ReadOnly = false;
            dataGridView2.Columns[7].Width = 30;
            dataGridView2.Columns[7].HeaderText = "";
            dataGridView2.Columns[9].Visible = false;
        }

        private void RegAdmin_Click(object sender, EventArgs e)
        {
            EditionInsertion  editionInsertion = new EditionInsertion();
            int index = dataGridView2.CurrentRow.Index;
            string Id = dataGridView2[0, index].Value.ToString();

            editionInsertion.textBox1.Text = Convert.ToString(dataGridView2[0, index].Value);
            editionInsertion.textBox2.Text = Convert.ToString(dataGridView2[1, index].Value);
            editionInsertion.textBox3.Text = Convert.ToString(dataGridView2[2, index].Value);
            editionInsertion.textBox4.Text = dataGridView2[3, index].Value.ToString();
            editionInsertion.textBox5.Text = dataGridView2[4, index].Value.ToString();
            editionInsertion.textBox6.Text = dataGridView2[5, index].Value.ToString();
            editionInsertion.textBox7.Text = dataGridView2[6, index].Value.ToString();

            if (editionInsertion.ShowDialog() == DialogResult.OK)
            {
                string Up_to_Date = "UPDATE Admins SET " +
                "Логин='" + editionInsertion.textBox1.Text + "'," +
                "Пароль='" + editionInsertion.textBox2.Text + "'," +
                "Фамилия='" + editionInsertion.textBox3.Text + "'," +
                "[Имя]='" + editionInsertion.textBox4.Text + "'," +
                "Отчество='" + editionInsertion.textBox5.Text + "'," +
                "[Номер телефона]='" + editionInsertion.textBox6.Text + "'," +
                "Гостиница='" + editionInsertion.textBox7.Text + "'" +
                " Where Логин='" + Id + "'";

                OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();
                ShowAdmins();
                editionInsertion.Close();
            }
        }

        private void DeleteAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить выбранные записи?", "FormDeleting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Updating(sender, e);
                ShowAdmins();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if ((bool)dataGridView2[7, i].Value == true && dataGridView2[6, i].Value.ToString()!="")
                    {
                        MessageBox.Show("Удаление невозможно, так как вы пытаетесь удалить администратора, который уже прикреплен к гостинице");
                        return;
                    }
                }
                string Up_to_Date = "Delete from Admins Where IsChecked=true";
                OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();
                ShowAdmins();
               /* for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    dataGridView2[9, i].Value = i + 1;
                    string Upd = "Update Guests Set ID=" + dataGridView2[9, i].Value + " Where [Паспортные данные]='" +dataGridView2[7, i].Value + "'";

                    sql_conn.Open();
                    sql_comm = new OleDbCommand(Upd, sql_conn);
                    sql_comm.ExecuteNonQuery();
                    sql_conn.Close();
                }*/
                //ShowAdmins();
            }

        }

        public void Updating(object sender, EventArgs e)
        {


            OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                string Up_to_Date = "Update Admins Set IsChecked=" + dataGridView2[7, i].EditedFormattedValue + " Where Логин='" + dataGridView2[0,i].Value.ToString()+"'";

                OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                // checkInHostel.dataBaseDataSet4.Guests.AcceptChanges();

                sql_conn.Close();
                // OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                // dataAdapter.
                // dataAdapter.Update(checkInHostel.dataBaseDataSet4.Guests);
            }
        }

        

       

        private void SelectAdmins_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell.IsInEditMode)
                dataGridView2.CurrentCell.Selected = false;
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2[7, i].Value = true;
                }
            }
        }

        private void CancelAdmins_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell.IsInEditMode)
                dataGridView2.CurrentCell.Selected = false;
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2[7, i].Value = false;
                }
            }
        }

        private void SelectHosts_Click(object sender, EventArgs e)
        {
            //if (advancedDataGridView1.CurrentCell.IsInEditMode)
              //  advancedDataGridView1.CurrentCell.Selected = false;
            if (advancedDataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < advancedDataGridView2.RowCount; i++)
                {
                    advancedDataGridView2[0, i].Value = true;
                }
            }
        }

        private void CancelHosts_Click(object sender, EventArgs e)
        {
           // if (advancedDataGridView1.CurrentCell.IsInEditMode)
             //   advancedDataGridView1.CurrentCell.Selected = false;
            if (advancedDataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < advancedDataGridView2.RowCount; i++)
                {
                    advancedDataGridView2[0, i].Value = false;
                }
            }
        }

        private void BlockAdmin_Click(object sender, EventArgs e)
        {
            Updating(sender,e);
           // SetIsBlocked(sender,e);
            ShowAdmins();
            //if (counter>0)
            //{
                for (int i=0;i<dataGridView2.Rows.Count;i++)
                {
                //if ((bool)dataGridView2[8, i].Value==true&&dataGridView2[9,i].Value==DBNull.Value)
                if ((bool)dataGridView2[7, i].Value == true && dataGridView2[9, i].Value == DBNull.Value)
                {
                        WhyBlocked whyBlocked = new WhyBlocked();
                        whyBlocked.name = dataGridView2[2, i].Value.ToString()+" " + dataGridView2[3, i].Value.ToString() +" "+ dataGridView2[4, i].Value.ToString();
                        if (whyBlocked.ShowDialog()==DialogResult.OK)
                        {
                            SetIsBlocked(sender, e);
                            string Update = "Update Admins Set Причина='"+whyBlocked.textBox1.Text+"' Where Логин='"+dataGridView2[0,i].Value+"'";
                            OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                            OleDbCommand sql_comm = new OleDbCommand(Update, sql_conn);

                            sql_conn.Open();
                           sql_comm.ExecuteNonQuery();
                            // checkInHostel.dataBaseDataSet4.Guests.AcceptChanges();

                            sql_conn.Close();
                        }
                    }
              //  }
                    }
            ShowAdmins();
        }
        public int counter;
        public void SetIsBlocked(object sender, EventArgs e)
        {
            OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
           
                string Up_to_Date = "Update Admins Set Заблокирован=true " + " Where IsChecked=true And Заблокирован=false";

                OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

                sql_conn.Open();
                counter=sql_comm.ExecuteNonQuery();
                // checkInHostel.dataBaseDataSet4.Guests.AcceptChanges();

                sql_conn.Close();
                // OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                // dataAdapter.
                // dataAdapter.Update(checkInHostel.dataBaseDataSet4.Guests);
            
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet5.Hosts". При необходимости она может быть перемещена или удалена.
            this.hostsTableAdapter.ConnStr = ConnectionString;
            this.hostsTableAdapter.Fill(this.dataBaseDataSet5.Hosts);

        }

        private void IncrementADG_Click(object sender, EventArgs e)
        {
            ChangeHosts changeHosts = new ChangeHosts();
            if (changeHosts.ShowDialog() == DialogResult.OK)
            {
                this.hostsTableAdapter.Insert(false, Convert.ToInt32(changeHosts.CurrentHost.Text), changeHosts.Lifts.Text, changeHosts.Rooms.Text, changeHosts.Country.Text,changeHosts.City.Text, changeHosts.Street.Text,changeHosts.Home.Text, advancedDataGridView2.Rows.Count+1);
                this.hostsTableAdapter.Fill(this.dataBaseDataSet5.Hosts);
                changeHosts.Close();
            }
        }

        private void EditionADG_Click(object sender, EventArgs e)
        {
            ChangeHosts changeHosts = new ChangeHosts();
            int index = advancedDataGridView2.CurrentRow.Index;
            string Country = advancedDataGridView2[4, index].Value.ToString();
            string City = advancedDataGridView2[5, index].Value.ToString();
            string Street = advancedDataGridView2[6, index].Value.ToString();
            string Home = advancedDataGridView2[7, index].Value.ToString();
            int Id = (int)advancedDataGridView2[8, index].Value;

            changeHosts.CurrentHost.Text = Convert.ToString(advancedDataGridView2[1, index].Value);
            changeHosts.Lifts.Text = Convert.ToString(advancedDataGridView2[2, index].Value);
            changeHosts.Rooms.Text = Convert.ToString(advancedDataGridView2[3, index].Value);
            changeHosts.Country.Text = Country;
            changeHosts.City.Text = City;
            changeHosts.Street.Text = Street;
            changeHosts.Home.Text = Home;

            if (changeHosts.ShowDialog() == DialogResult.OK)
            {
                //this._commandCollection[0].CommandText = "SELECT IsChecked, [Номер гостиницы], [Количество этажей], [Количество номеров], С" +
                //"трана, Город, Улица, Дом, ID FROM Hosts";
                //this._connection.ConnectionString = ConnStr;
                this.hostsTableAdapter.UpdateQuery(Convert.ToInt32(changeHosts.CurrentHost.Text), changeHosts.Lifts.Text, changeHosts.Rooms.Text, changeHosts.Country.Text, changeHosts.City.Text, changeHosts.Street.Text, changeHosts.Home.Text, Id);
                this.hostsTableAdapter.Fill(dataBaseDataSet5.Hosts);
                changeHosts.Close();
            }
        }

        private void DeleteADG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить выбранные записи?", "Удаление гостиниц", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < advancedDataGridView2.Rows.Count; i++)
                    this.hostsTableAdapter.UpdateIsChecked((bool)advancedDataGridView2[0,i].EditedFormattedValue, i+1);

                int index = (int)advancedDataGridView2[8, 0].Value;
                int count=this.hostsTableAdapter.DeleteQuery();
                if (count == 0)
                {
                    MessageBox.Show("Вы не можете удалить гостиницы, с которыми связаны номера");
                }
                this.hostsTableAdapter.Fill(dataBaseDataSet5.Hosts);
                for (int i = index; i < advancedDataGridView2.Rows.Count + index; i++)
                {
                    advancedDataGridView2[8, i - 1].Value = i;
                    this.hostsTableAdapter.UpdateID((int)advancedDataGridView2[8, i - 1].Value, (int)advancedDataGridView2[1, i - 1].Value);
                }
                this.hostsTableAdapter.Fill(dataBaseDataSet5.Hosts);
            }
        }
    }
}
