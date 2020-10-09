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
using System.IO;

namespace Создание_управления_сетью_гостиниц
{
    public partial class CheckInHostel : Form
    {

        public int Host;
        public string direct;
        public string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Mode=ReadWrite;Persist Security Info=True;User ID=Admin;Data Source=";
        public CheckInHostel()
        {
            InitializeComponent();
            direct = @Directory.GetCurrentDirectory();
            ConnectionString += direct + @"\\DataBase.accdb";
            // GridCheckIn = ShowChecked(new Administrator().GridGuests);
            // this.ShowDialog();
            // this.GridCheckIn.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCheckIn_CellEndEdit);
        }


       /* public void ShowGuests(string Guests)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(Guests, ConnectionString);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            GridCheckIn.DataSource = dataTable.DefaultView;
            //advancedData.DataSource = dataTable.DefaultView;
            //GridCheckIn.ReadOnly = false;
            string Hostel = "Select Номер From hostel";
             dataAdapter = new OleDbDataAdapter(Hostel, ConnectionString);
            var dataTable1 = new DataTable();
            dataAdapter.Fill(dataTable1);
            var column = new DataGridViewComboBoxColumn();
            column.DataSource = dataTable1;
            column.DataPropertyName = "Номер";
            column.DisplayMember = "Номер";
            column.ValueMember = "Номер";
            //dataTable.Columns.Add(column);
            
            GridCheckIn.Columns.Add(column);

            GridCheckIn.Columns[7].Width = 150;
            GridCheckIn.Columns[7].HeaderText = "Доступные номера";
            GridCheckIn.Columns[7].ReadOnly = false;
            //advancedData.Columns.Add(column);
            //advancedData.Columns[6].ReadOnly = false;
            this.GridCheckIn.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(GridCheckIn_EditingControlShowing);
        }*/

       /* ComboBox comboBox;
        DataGridViewCell currentCell;
        private void GridCheckIn_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)

            {

                comboBox = (ComboBox)e.Control;

                if (comboBox != null)

                {

                    comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);

                }

                currentCell = this.GridCheckIn.CurrentCell;

            }
        }*/
    private void Ok_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

       

       /* private void GridCheckIn_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)GridCheckIn[0, GridCheckIn.CurrentRow.Index].Value;
            comboBox.SelectedItem = (object)GridCheckIn[0, GridCheckIn.CurrentRow.Index].EditedFormattedValue;
            GridCheckIn[0, GridCheckIn.CurrentRow.Index].Value = comboBox.SelectedItem;
        }*/

        /*private void GridCheckIn_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(" " + GridCheckIn[0, GridCheckIn.CurrentRow.Index].Value + " ", "" + GridCheckIn.Columns.Count + "", MessageBoxButtons.YesNo);
            if (comboBox != null)

            {

                comboBox.SelectedIndexChanged -= new EventHandler(comboBox_SelectedIndexChanged);
            }
        }*/


       /* void comboBox_SelectedIndexChanged(object sender, EventArgs e)

        {

            this.BeginInvoke(new MethodInvoker(EndEdit));

        }



        void EndEdit()

        {

            if (comboBox != null)

            {

                DataRowView drv = comboBox.SelectedItem as DataRowView;
                if (drv != null)

                {
                    MessageBox.Show(" " + GridCheckIn[0, GridCheckIn.CurrentRow.Index].EditedFormattedValue + " ", "" + drv[0].ToString() + "", MessageBoxButtons.YesNo);
                    this.GridCheckIn[0, currentCell.RowIndex].Value = Convert.ToInt32(drv[0]);
                    GridCheckIn.UpdateCellValue(0, currentCell.RowIndex);
                    
                   
                    MessageBox.Show(" " + GridCheckIn[0, GridCheckIn.CurrentRow.Index].Value + " ", "" + GridCheckIn.Columns.Count + "", MessageBoxButtons.YesNo);
                    this.GridCheckIn.EndEdit();

                }

            }

        }*/

        public void CheckInHostel_Load(object sender, EventArgs e)
        {


            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet4.Guests". При необходимости она может быть перемещена или удалена.
            //guestsTableAdapter = new DataBaseDataSet4TableAdapters.GuestsTableAdapter();
            //OleDbCommand command= guestsTableAdapter.Connection.CreateCommand();
            //OleDbCommand command = new OleDbCommand("Select Номер, ID From hostel where Гостиница="+Host);
            //guestsTableAdapter.Connection.ConnectionString = ConnectionString;
            //guestsTableAdapter.Connection.Open();
            // guestsTableAdapter.
            //guestsTableAdapter = new DataBaseDataSet4TableAdapters.GuestsTableAdapter();
            this.hostelTableAdapter.CurrHost = Host;
            this.hostelTableAdapter.ConnStr = ConnectionString;
           // hostelTableAdapter.Connection.CreateCommand().CommandText= "Select Номер, ID From hostel Where Гостиница=" + Host;
            this.hostelTableAdapter.Fill(this.dataBaseDataSet4.hostel);
            this.guestsTableAdapter.ConnStr = ConnectionString;
            this.guestsTableAdapter.Fill(this.dataBaseDataSet4.Guests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet4.hostel". При необходимости она может быть перемещена или удалена.

        }



        /*
         1591 this._connection.ConnectionString = global::Создание_управления_сетью_гостиниц.Properties.Settings.Default.DataBaseConnectionString;
          this.CommandCollection[0].CommandText = "Select Номер, ID From hostel Where Гостиница = " + CurrHost;
            this.Connection.ConnectionString = ConnStr;
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
         */


        /* private void GridCheckIn_CurrentCellDirtyStateChanged(object sender, EventArgs e)
{
    MessageBox.Show(" " + GridCheckIn[0, GridCheckIn.CurrentRow.Index].EditedFormattedValue + " ", "" + GridCheckIn.Columns.Count + "", MessageBoxButtons.YesNo);
    GridCheckIn.CurrentCellDirtyStateChanged -= GridCheckIn_CurrentCellDirtyStateChanged;
    GridCheckIn.CommitEdit(DataGridViewDataErrorContexts.Commit);
    GridCheckIn.BindingContext[GridCheckIn.DataSource].EndCurrentEdit();
}*/

        /*private void GridCheckIn_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }*/

        /*private void GridCheckIn_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }*/

        /*  private void GridCheckIn_SelectionChanged(object sender, EventArgs e)
          {
              ComboBox cellComboBox = (ComboBox)GridCheckIn.EditingControl;
              GridCheckIn[7, GridCheckIn.CurrentRow.Index].Value = cellComboBox.SelectedValue;
          }*/

        /*  private void GridCheckIn_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
          {
              if (GridCheckIn.CurrentCell.ColumnIndex == 0) // 1 - индекс колонки с комбо-боксами
              {
                  ComboBox cellComboBox = (ComboBox)e.Control;
                  GridCheckIn[0, GridCheckIn.CurrentRow.Index].Value = cellComboBox.SelectedItem;
              }

          }*/



        /* private void GridCheckIn_CurrentCellDirtyStateChanged(object sender, EventArgs e)
          {
              MessageBox.Show(" " + GridCheckIn[0, GridCheckIn.CurrentRow.Index].EditedFormattedValue + " ", "" + GridCheckIn.Columns.Count + "", MessageBoxButtons.YesNo);
                  GridCheckIn.CommitEdit(DataGridViewDataErrorContexts.Commit);
                  GridCheckIn.BindingContext[GridCheckIn.DataSource].EndCurrentEdit();
          }*/




    }
}


