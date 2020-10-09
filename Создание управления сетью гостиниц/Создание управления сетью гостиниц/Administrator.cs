using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Создание_управления_сетью_гостиниц
{
    public partial class Administrator : Form
    {
        public string Guests = "Select * From [Guests]";
        public string direct;
        //public string Hostel = "Select*From hostel";
        public string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Mode=ReadWrite;Persist Security Info=True;User ID=Admin;Data Source=";
        public Administrator()
        {
            InitializeComponent();
            direct = @Directory.GetCurrentDirectory();
            ConnectionString += direct + @"\\DataBase.accdb";
//ShowGuests();
        }
        public string GuestConn;
        public void ShowGuests()
        {
            if (HostelAd.Text == "")
            {
                MessageBox.Show("Вы не сможете контролировать постояльцами гостиницы, так как вы к ней не привязаны");
                return;
            }
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(Guests+ " Where Гостиница="+HostelAd.Text, ConnectionString);
            //DataSet set = new DataSet();
            DataSet dataSet = new DataSet();
            int count=dataAdapter.Fill(dataSet);
            GridGuests.DataSource = dataSet.Tables[0].DefaultView;
            
            GridGuests.RowHeadersVisible = false;
            GridGuests.ReadOnly = false;
            GridGuests.MultiSelect = true;
            foreach (DataGridViewColumn column in GridGuests.Columns)
                column.ReadOnly = true;
            GridGuests.Columns[0].DisplayIndex = 0;
            GridGuests.Columns[0].ReadOnly = false;
            GridGuests.Columns[0].Width = 30;
            GridGuests.Columns[0].HeaderText = "";
            GridGuests.Columns[8].Visible = false;
            GridGuests.Columns[9].Visible = false;
            GridGuests.Columns[10].Visible = false;
            GridGuests.Columns[11].Visible = false;
        }
        public string CurrHost;
        public void ShowHostel()
        {
            if (HostelAd.Text == "")
            {
                MessageBox.Show("Вы не сможете контролировать номерами гостиницы, так как вы к ней не привязаны");
                return; 
            }
                CurrHost = "Select * From hostel Where Гостиница=" + HostelAd.Text + ""; //IsChecked,Номер, [Число комнат], [Площадь (в квадратных метрах)] 
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CurrHost, ConnectionString);

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                GridHostel.DataSource = dataSet.Tables[0].DefaultView;
                GridHostel.RowHeadersVisible = false;
                GridHostel.ReadOnly = false;
                GridHostel.MultiSelect = true;
                foreach (DataGridViewColumn column in GridHostel.Columns)
                    column.ReadOnly = true;
                GridHostel.Columns[0].ReadOnly = false;
                GridHostel.Columns[0].Width = 30;
                GridHostel.Columns[0].HeaderText = "";
                GridHostel.Columns[2].Visible = false;
                GridHostel.Columns[5].Visible = false;
        }

        private void Administrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Insertion_Click(object sender, EventArgs e)
        {
            if (HostelAd.Text == "")
            {
                MessageBox.Show("Вы не сможете контролировать постояльцами гостиницы, так как вы к ней не привязаны");
                return;
            }
            ChangeGuests changeGuests = new ChangeGuests();
            if (changeGuests.ShowDialog()==DialogResult.OK)
            {
                
                string Up_to_Date = "Insert into Guests (Фамилия, Имя, Отчество, [Дата рождения], Пол, [Номер телефона], [Паспортные данные], ID, Гостиница) Values (" +
                "'" + changeGuests.Familia.Text + "'," +
                "'" + changeGuests.Imya.Text + "'," +
                "'" + changeGuests.Otchestvo.Text + "'," +
                "'" + changeGuests.WasBorn.Text + "'," +
                "'" + changeGuests.Floor.Text + "'," +
                "'" + changeGuests.Number.Text + "'," +
                "'" + changeGuests.Pachport.Text + "'," +
                (GridGuests.Rows.Count + 1) +","+
                HostelAd.Text+ ")";

                OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();
                ShowGuests();
                changeGuests.Close();
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (HostelAd.Text == "")
            {
                MessageBox.Show("Вы не сможете контролировать постояльцами гостиницы, так как вы к ней не привязаны");
                return;
            }
            ChangeGuests changeGuests = new ChangeGuests();
            int index = GridGuests.CurrentRow.Index;
            int Id = (int)GridGuests[9, index].Value;

            changeGuests.Familia.Text = Convert.ToString(GridGuests[1, index].Value);
            changeGuests.Imya.Text = Convert.ToString(GridGuests[2, index].Value);
            changeGuests.Otchestvo.Text = Convert.ToString(GridGuests[3, index].Value);
            changeGuests.WasBorn.Text = GridGuests[4,index].Value.ToString();
            changeGuests.Floor.Text = GridGuests[5, index].Value.ToString();
            changeGuests.Number.Text = GridGuests[6, index].Value.ToString();
            changeGuests.Pachport.Text = GridGuests[7, index].Value.ToString();

            if (changeGuests.ShowDialog() == DialogResult.OK)
            {
                string Up_to_Date = "UPDATE Guests SET " +
                "Фамилия='" + changeGuests.Familia.Text + "'," +
                "Имя='" + changeGuests.Imya.Text + "'," +
                "Отчество='" + changeGuests.Otchestvo.Text + "'," +
                "[Дата рождения]='" + changeGuests.WasBorn.Text + "'," +
                "Пол='" + changeGuests.Floor.Text + "'," +
                "[Номер телефона]='" + changeGuests.Number.Text + "'," +
                "[Паспортные данные]='" + changeGuests.Pachport.Text + "'" +
                " Where ID=" + Id + " And Гостиница="+HostelAd.Text;

                OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();
                ShowGuests();
                changeGuests.Close();
            }

        }

        private void GridGuests_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            //if (GridGuests.CurrentCell.IsInEditMode)
             //GridGuests.CurrentCell.Selected = false;
            if (GridGuests.Rows.Count > 0)
            {
                for (int i = 0; i < GridGuests.RowCount; i++)
                {
                    GridGuests[0, i].Value = true;
                }
            }
        }

        private void CancelAll_Click(object sender, EventArgs e)
        {
            //if (GridGuests.CurrentCell.IsInEditMode)
              //  GridGuests.CurrentCell.Selected = false;
            if (GridGuests.Rows.Count > 0)
            {
                for (int i = 0; i < GridGuests.RowCount; i++)
                {
                    GridGuests[0, i].Value = false;
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (HostelAd.Text == "")
            {
                MessageBox.Show("Вы не сможете контролировать постояльцами гостиницы, так как вы к ней не привязаны");
                return;
            }
            if (MessageBox.Show("Вы уверены, что хотите удалить выбранные записи?", "FormDeleting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Updating(sender, e);
                string Up_to_Date = "Delete * from Guests Where IsChecked=true And Гостиница="+ HostelAd.Text+" And Заселен=false";
                OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

                sql_conn.Open();
                int count=sql_comm.ExecuteNonQuery();
                
                sql_conn.Close();
                if (count == 0)
                {
                    MessageBox.Show("Вы не можете удалять постояльцев, которые уже заселены в гостинице вашей сети");
                }
                ShowGuests();
                for (int i = 0; i < GridGuests.Rows.Count; i++)
                {
                    GridGuests[9, i].Value = i + 1;
                    string Upd = "Update Guests Set ID=" + GridGuests[9, i].Value + " Where [Паспортные данные]='" + GridGuests[7, i].Value + "'";

                    sql_conn.Open();
                    sql_comm = new OleDbCommand(Upd, sql_conn);
                    sql_comm.ExecuteNonQuery();
                    sql_conn.Close();
                }
                ShowGuests();
            }

        }

        public void Updating(object sender, EventArgs e)
        {
           
            
            OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
            for (int i=0; i<GridGuests.Rows.Count;i++)
            {
                string Up_to_Date = "Update Guests Set IsChecked=" + GridGuests[0, i].EditedFormattedValue + " Where ID="+(i+1)+" And Гостиница="+HostelAd.Text;
                
                OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
               // checkInHostel.dataBaseDataSet4.Guests.AcceptChanges();
                
                sql_conn.Close();
               // OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
               // dataAdapter.
               // dataAdapter.Update(checkInHostel.dataBaseDataSet4.Guests);
            }
            // BindingSource bindingSource = new BindingSource(checkInHostel.dataBaseDataSet4, "IsChecked");
          // CheckInHostel checkInHostel = new CheckInHostel();
           // DataBaseDataSet4TableAdapters.GuestsTableAdapter guestsTableAdapter = new DataBaseDataSet4TableAdapters.GuestsTableAdapter();
            //guestsTableAdapter.Connection.ConnectionString = ConnectionString;
            //guestsTableAdapter.Connection.Open();
            //guestsTableAdapter.Fill(checkInHostel.dataBaseDataSet4.Guests);
            //guestsTableAdapter.Connection.Close();
           // OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select*From Guests", ConnectionString);
            //dataAdapter.Fill(checkInHostel.dataBaseDataSet4, "Guests");
            //guestsTableAdapter.Fill(checkInHostel.dataBaseDataSet4.Guests);
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (HostelAd.Text == "")
            {
                MessageBox.Show("Вы не сможете выгружать постояльцев гостиницы, так как вы к ней не привязаны");
                return;
            }
            using (FolderBrowserDialog saveFileDialog = new FolderBrowserDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.SelectedPath;
                    
                        FileStream fileStream = File.Create(path + "\\" + "ПостояльцыГостиницы№" +HostelAd.Text+ ".txt");
                        //fileStream.Close();
                        string CSV = "";
                        for (int i = 1; i < GridGuests.Columns.Count - 4; i++)
                            CSV += GridGuests.Columns[i].HeaderText + ";";
                        CSV += "\n";
                        for (int i = 0; i < GridGuests.Rows.Count; i++)
                        {
                            if ((bool)GridGuests[0, i].Value)
                            {
                                for (int j = 1; j < GridGuests.Columns.Count - 4; j++)
                                {
                                    CSV += GridGuests[j, i].Value.ToString() + ";";
                                }
                                CSV += "\n";
                            }
                        }
                        byte[] info = new UTF8Encoding(true).GetBytes(CSV);
                        fileStream.Write(info, 0, info.Length);
                        fileStream.Close();
                        

                    

                }
            }

           /* string CSV = "";
            for (int i = 1; i < GridGuests.Columns.Count-1; i++)
                CSV += GridGuests.Columns[i].HeaderText + ";";
            CSV += "\n";
            for (int i = 0; i < GridGuests.Rows.Count; i++)
            {
                if ((bool)GridGuests[0, i].Value)
                {
                    for (int j = 1; j < GridGuests.Columns.Count - 1; j++)
                    {
                        CSV += GridGuests[j, i].Value.ToString() + ";";
                    }
                    CSV += "\n";
                }
            }*/
            //Console.WriteLine(CSV);
            //StreamWriter streamWriter = new StreamWriter(@"C:\Users\user\source\repos\Создание управления сетью гостиниц\CSVFile.csv");
            //streamWriter.Write(CSV,Encoding.UTF8);
            //streamWriter.Close();
        }

        private void Inserthostel_Click(object sender, EventArgs e)
        {
            if (HostelAd.Text == "")
            {
                MessageBox.Show("Вы не сможете контролировать номерами гостиницы, так как вы к ней не привязаны");
                return;
            }
            EditHostel editHostel = new EditHostel();
            if (editHostel.ShowDialog() == DialogResult.OK)
            {
                string Up_to_Date = "Insert into hostel (Номер,[Число комнат], [Площадь (в квадратных метрах)], ID, Гостиница) Values (" +
                 editHostel.Number.Text + "," +
                 editHostel.Rooms.Text + "," +
                 editHostel.Square.Text + "," +
                (GridHostel.Rows.Count + 1) + ","+HostelAd.Text+")";

                OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();
                ShowHostel();
                editHostel.Close();
            }
        }

        private void EditHostel_Click(object sender, EventArgs e)
        {
            if (HostelAd.Text == "")
            {
                MessageBox.Show("Вы не сможете контролировать номерами гостиницы, так как вы к ней не привязаны");
                return;
            }
            EditHostel editHostel = new EditHostel();
            int index = GridHostel.CurrentRow.Index;
            int Id = (int)GridHostel[5, index].Value;

            editHostel.Number.Text = Convert.ToString(GridHostel[1, index].Value);
            editHostel.Rooms.Text = Convert.ToString(GridHostel[3, index].Value);
            editHostel.Square.Text = Convert.ToString(GridHostel[4, index].Value);

            if (editHostel.ShowDialog() == DialogResult.OK)
            {
                string Up_to_Date = "UPDATE hostel SET " +
                "Номер=" + editHostel.Number.Text + "," +
                "[Число комнат]=" + editHostel.Rooms.Text + "," +
                "[Площадь (в квадратных метрах)]=" + editHostel.Square.Text +
                " Where ID=" + Id + "";

                OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();
                ShowHostel();
                editHostel.Close();
            }
        }

        private void deleteHostel_Click(object sender, EventArgs e)
        {
            if (HostelAd.Text == "")
            {
                MessageBox.Show("Вы не сможете контролировать номерами гостиницы, так как вы к ней не привязаны");
                return;
            }
            if (MessageBox.Show("Вы уверены, что хотите удалить выбранные записи?", "FormDeleting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UpdateHostels();
                for (int i = 0; i < GridHostel.Rows.Count; i++)
                    if ((bool)GridHostel[6, i].Value == true&&(bool)GridHostel[0,i].Value==true)
                    {
                        MessageBox.Show("Вы не можете удалять номера, в которых проживают постояльцы");
                        return;
                    }
 
                int index = (int)GridHostel[5, 0].Value;
                string Up_to_Date = "Delete from hostel Where IsChecked=true";
                OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();
                ShowHostel();
                for (int i = index; i < GridHostel.Rows.Count+index; i++)
                {
                    GridHostel[5, i-1].Value = i;
                    string Upd = "Update hostel Set ID=" + GridHostel[5, i-1].Value + " Where [Номер]=" + GridHostel[1, i-1].Value + "";

                    sql_conn.Open();
                    sql_comm = new OleDbCommand(Upd, sql_conn);
                    sql_comm.ExecuteNonQuery();
                    sql_conn.Close();
                }
                ShowHostel();
            }
        }

        public void UpdateHostels()
        {
            OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
            for (int i = 0; i < GridHostel.Rows.Count; i++)
            {
                string Up_to_Date = "Update hostel Set IsChecked=" + GridHostel[0, i].EditedFormattedValue + " Where ID=" + (i + 1);

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

        private void Select1_Click(object sender, EventArgs e)
        {
            //if (GridHostel.CurrentCell.IsInEditMode)
              //  GridHostel.CurrentCell.Selected = false;
            if (GridHostel.Rows.Count > 0)
            {
                for (int i = 0; i < GridHostel.RowCount; i++)
                {
                    GridHostel[0, i].Value = true;
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            //if (GridHostel.CurrentCell.IsInEditMode)
              //  GridHostel.CurrentCell.Selected = false;
            if (GridHostel.Rows.Count > 0)
            {
                for (int i = 0; i < GridHostel.RowCount; i++)
                {
                    GridHostel[0, i].Value = false;
                }
            }
        }

        private void CheckIn_Click(object sender, EventArgs e)
        {
            if (HostelAd.Text == "")
            {
                MessageBox.Show("Вы не сможете заселять постояльцев гостиницы, так как вы к ней не привязаны");
                return;
            }
            Updating(sender, e);
            CheckInHostel checkInHostel = new CheckInHostel();
            checkInHostel.Host = Convert.ToInt32(HostelAd.Text);
           // checkInHostel.CheckInHostel_Load(sender,e);
           // string Guests = "Select Фамилия, Имя, Отчество, [Дата рождения], Пол, [Номер телефона], [Паспортные данные] From Guests Where IsChecked=true";
            //checkInHostel.ShowGuests(Guests);
           // checkInHostel.GridCheckIn=checkInHostel.ShowChecked(GridGuests);
          
            if (checkInHostel.ShowDialog()==DialogResult.OK)
            {
                //string put = "Сохранить здесь";
                string fileName = null;
                //bool b = false;
                for (int i=0;i< GridHostel.Rows.Count;i++)
                {
                    for (int j = 0; j < checkInHostel.advancedDataGridView1.Rows.Count; j++)
                         if (GridHostel[1, i].Value == checkInHostel.advancedDataGridView1[7, j].Value && (bool)GridHostel[6, i].Value == true)
                            {
                            MessageBox.Show("Невозможно заселить постояльцев, так как номер уже занят");
                            //        b = true;
                            return;
                            }

                    for (int j = 0; j < checkInHostel.advancedDataGridView1.Rows.Count; j++)
                        if (GridHostel[1, i].Value.ToString() == (string)checkInHostel.advancedDataGridView1[7, j].EditedFormattedValue && (bool)GridHostel[6, i].Value != true)
                        {
                            ZaselTr(i);
                            Incrementnumber(j, i,checkInHostel);
                        }
                  //  if (b) break;
                }
                
                //if (b) return;
                //{ Filter = "Word (*.doc;*.docx;*.txt;*.rtf)|*.doc;*.docx;*.txt;*.rtf|All files (*.*)|*.*" }
                using (FolderBrowserDialog saveFileDialog = new FolderBrowserDialog())
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog.SelectedPath;
                        for (int i=0;i<checkInHostel.advancedDataGridView1.Rows.Count;i++)
                        {
                            fileName = checkInHostel.advancedDataGridView1[0, i].Value.ToString() + " "
                                + checkInHostel.advancedDataGridView1[1, i].Value.ToString() + " "
                                + checkInHostel.advancedDataGridView1[2, i].Value.ToString();
                            FileStream fileStream = File.Create(path+"\\"+"ЗАСЕЛЕНИЕ."+fileName+".txt");
                            //fileStream.Close();
                            string Zasel = "Заселение\nПостоялец " + fileName + "\nГостиница " + HostelAd.Text + "\nНомер гостиницы " + checkInHostel.advancedDataGridView1[7, i].FormattedValue.ToString() + "\nАдминистратор " + Admin.Text + "\nДата заселения " + DateTime.Today.ToShortDateString();
                            byte[] info = new UTF8Encoding(true).GetBytes(Zasel);
                            fileStream.Write(info, 0, info.Length);
                            fileStream.Close();
                            //StreamWriter streamWriter = new StreamWriter(path + "\\" + fileName+".txt");
                            //streamWriter.Write("Заселение");
                            //streamWriter.WriteLine("Постоялец "+fileName);
                            //streamWriter.WriteLine("Гостиница "+HostelAd.Text);
                            //streamWriter.WriteLine("Номер "+checkInHostel.advancedDataGridView1[7,i].Value.ToString());
                            //streamWriter.WriteLine("Администратор"+Admin.Text);
                            //streamWriter.WriteLine("Дата заселения "+DateTime.Today.ToString());
                            
                        }
                        
                    }
                }
            }
        }

        public void ZaselTr(int index)
        {
            OleDbConnection sql_conn = new OleDbConnection(ConnectionString);

            string Up_to_Date = "Update hostel Set Заселен=true" + " Where Номер=" + GridHostel[1, index].Value +" And Гостиница="+HostelAd.Text;

            OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

            sql_conn.Open();
            sql_comm.ExecuteNonQuery();
            // checkInHostel.dataBaseDataSet4.Guests.AcceptChanges();
            
            sql_conn.Close();
            ShowHostel();
            // OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            // dataAdapter.
            // dataAdapter.Update(checkInHostel.dataBaseDataSet4.Guests);

        }

        public void Incrementnumber(int index, int number, CheckInHostel checkInHostel)
        {
            OleDbConnection sql_conn = new OleDbConnection(ConnectionString);

            string Up_to_Date = "Update Guests Set Заселен = true, [Число заселений]=[Число заселений]+1," +" [Номер заселения]="+GridHostel[1,number].Value +" Where [Паспортные данные]='" + checkInHostel.advancedDataGridView1[6, index].Value+ "' And Гостиница="+HostelAd.Text;

            OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

            sql_conn.Open();
            sql_comm.ExecuteNonQuery();
            // checkInHostel.dataBaseDataSet4.Guests.AcceptChanges();

            sql_conn.Close();
            ShowGuests();
        }



        private void CheckOut_Click(object sender, EventArgs e)
        {
            if (HostelAd.Text == "")
            {
                MessageBox.Show("Вы не сможете выселять постояльцев гостиницы, так как вы к ней не привязаны");
                return;
            }
            Updating(sender, e);
            CheckInHostel checkInHostel = new CheckInHostel();
            checkInHostel.advancedDataGridView1.Columns[7].Visible = false;
            checkInHostel.Text = "Выселение";
            checkInHostel.label1.Text = "Отмеченные к выселению постояльцы";
            if (checkInHostel.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < GridGuests.Rows.Count; i++)
                
                    if ((bool)GridGuests[0, i].Value == true && (bool)GridGuests[10, i].Value == false)
                    {
                        MessageBox.Show("Вы не можете выселить постояльцев, если они еще не были заселены");
                        return;
                    }
                for (int i = 0; i < GridGuests.Rows.Count; i++)
                    if ((bool)GridGuests[0, i].Value == true)
                    NotStated(i);
                
                string fileName = null;
                using (FolderBrowserDialog saveFileDialog = new FolderBrowserDialog())
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog.SelectedPath;
                        for (int i = 0; i < checkInHostel.advancedDataGridView1.Rows.Count; i++)
                        {
                            fileName = checkInHostel.advancedDataGridView1[0, i].Value.ToString() + " "
                                + checkInHostel.advancedDataGridView1[1, i].Value.ToString() + " "
                                + checkInHostel.advancedDataGridView1[2, i].Value.ToString();
                            FileStream fileStream = File.Create(path + "\\" + "ВЫСЕЛЕНИЕ." + fileName + ".txt");
                            //fileStream.Close();
                            string Zasel = "Выселение\nПостоялец " + fileName + "\nГостиница " + HostelAd.Text + "\nНомер гостиницы " + checkInHostel.advancedDataGridView1[7, i].FormattedValue.ToString() + "\nАдминистратор " + Admin.Text + "\nДата выселения " + DateTime.Today.ToShortDateString();
                            byte[] info = new UTF8Encoding(true).GetBytes(Zasel);
                            fileStream.Write(info, 0, info.Length);
                            fileStream.Close();
                            //StreamWriter streamWriter = new StreamWriter(path + "\\" + fileName+".txt");
                            //streamWriter.Write("Заселение");
                            //streamWriter.WriteLine("Постоялец "+fileName);
                            //streamWriter.WriteLine("Гостиница "+HostelAd.Text);
                            //streamWriter.WriteLine("Номер "+checkInHostel.advancedDataGridView1[7,i].Value.ToString());
                            //streamWriter.WriteLine("Администратор"+Admin.Text);
                            //streamWriter.WriteLine("Дата заселения "+DateTime.Today.ToString());

                        }

                    }
                }
            }
        }

        public void NotStated(int index)
        {
            OleDbConnection sql_conn = new OleDbConnection(ConnectionString);

            string Up_to_Date = "Update Guests Set Заселен = false Where [Паспортные данные]='"+GridGuests[7, index].Value+"' And Гостиница="+HostelAd.Text;

            OleDbCommand sql_comm = new OleDbCommand(Up_to_Date, sql_conn);

            sql_conn.Open();
            sql_comm.ExecuteNonQuery();
            sql_conn.Close();
            ShowGuests();

            OleDbConnection sql_conn1 = new OleDbConnection(ConnectionString);

            string Up_to_Date1 = "Update hostel Set Заселен = false Where [Номер]=" + GridGuests[12, index].Value + " And Гостиница=" + HostelAd.Text;

            OleDbCommand sql_comm1 = new OleDbCommand(Up_to_Date1, sql_conn1);

            sql_conn1.Open();
            sql_comm1.ExecuteNonQuery();
            sql_conn1.Close();
            ShowHostel();
        }
        private void Administrator_Load(object sender, EventArgs e)
        {
            if (HostelAd.Text == "")
            { SelectAll.Enabled = false;
                CancelAll.Enabled = false;
                Select1.Enabled = false;
                Cancel.Enabled = false;
            }
            ShowHostel();
            ShowGuests();
        }
    }
}
