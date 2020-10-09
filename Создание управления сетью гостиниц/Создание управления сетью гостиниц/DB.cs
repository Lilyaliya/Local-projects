using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace Создание_управления_сетью_гостиниц
{
    class DB
    {
        public DataSet dataSet1 = new DataSet();
        public int indexator;
        public string direct;
        public string CmdText = "SELECT*FROM Admins";
        public string CmdText2 = "Select*From Iter";
        public string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Mode=ReadWrite;Persist Security Info=True;User ID=Admin;Data Source=";

        OleDbDataAdapter dataAdapter;
        HashSet<Componentes> duration = new HashSet<Componentes>()
        { new Componentes{ role="Manager", login="Manager", password="Manager"},
        new Componentes{role="Administrator", login="Admin", password="Admin"} };
        public struct Componentes
        {
            public string role { get; set; }
            public string login { get; set; }
            public string password { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Otchestvo { get; set; }
            public string number { get; set; }
            public string host { get; set; }
            public int iterator { get; set; }

            public bool isBlocked { get; set; }

            public string reason { get; set; }
            public IEnumerable<object> Compens()
            {
                yield return login;
                yield return password;
                yield return Name;
                yield return Surname;
                yield return Otchestvo;
                yield return number;
                yield return host;
            }
        }

       // public Componentes comp = new Componentes { };
        public bool IsValid(string log, string pass)
        {
            return duration.ToList().Exists((x) => { return x.login == log && x.password == pass; });
        }

        public Componentes Key(string log, string pass)
        {
             return duration.ToList().Find((x) => x.login == log && x.password == pass);
        }
        public void InitConn()
        {
            direct = @Directory.GetCurrentDirectory();
            if (ConnectionString.Contains(direct))
                return;
            ConnectionString += direct + @"\\DataBase.accdb";
        }
        public void ChangeDB()
        {
            InitConn();
            dataAdapter = new OleDbDataAdapter(CmdText, ConnectionString);
            DataSet dataSet = new DataSet();
            
            int count=dataAdapter.Fill(dataSet);
            //dataAdapter.Fill(dataSet1, "[Iter]");

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                
                Componentes componentes = new Componentes { role = "Administrator" };
                /*foreach (DataColumn column in dataSet.Tables[0].Columns)
                { componentes.Compens().ToList()[column.Ordinal] = row[column.Ordinal];
                   // componentes.compens().GetEnumerator().Current = row[column.Ordinal];
                }*/
                componentes.login = row[0].ToString();
                componentes.password = row[1].ToString();
                componentes.Name = row[3].ToString();
                componentes.Surname = row[2].ToString();
                componentes.Otchestvo = row[4].ToString();
                componentes.number = row[5].ToString();
                //int? h = null;

                componentes.host = row[6].ToString() ;
                componentes.isBlocked = (bool)row[8];
                componentes.reason = row[9].ToString();
                duration.Add(componentes);

            }
            //duration.Add((Componentes)row[column]);
        }

        public void Updating(int index, Form1 form1)
        {
            InitConn();
            bool ifpro = false;
            indexator = index;
            dataAdapter = new OleDbDataAdapter(CmdText2,ConnectionString);
            dataSet1 = new DataSet();
            dataAdapter.Fill(dataSet1,"Iter");
                for (int i = 0; i < dataSet1.Tables[0].Rows.Count;i++)
                {
                    if ((int)dataSet1.Tables[0].Rows[i][1]==index)
                    {
                        ifpro = true;
                        if ((int)dataSet1.Tables[0].Rows[i][0] < 3)
                        {
                            string Update = "Update Iter Set [Число попыток входа]=[Число попыток входа]+1 Where ID=" + index;
                            OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                            OleDbCommand sql_comm = new OleDbCommand(Update, sql_conn);
                        MessageBox.Show("Неправильный логин или пароль");
                            sql_conn.Open();
                            sql_comm.ExecuteNonQuery();
                            sql_conn.Close();
                        dataSet1 = new DataSet();
                            dataAdapter.Fill(dataSet1, "Iter");
                        }
                        else 
                        {
                            if ((int)dataSet1.Tables[0].Rows[i][2] == 0)
                            {
                                string Update = "Update Iter Set [Отсчет таймера]=60 Where ID=" + index;
                                OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                                OleDbCommand sql_comm = new OleDbCommand(Update, sql_conn);
                                sql_conn.Open();
                                sql_comm.ExecuteNonQuery();
                                sql_conn.Close();
                                dataSet1 = new DataSet();
                                dataAdapter.Fill(dataSet1, "Iter");
                                Blocking blocking = new Blocking();
                                blocking.indexator = index;
                                blocking.timeLeft = 60;
                                form1.Hide();
                                blocking.Show();
                            }

                            else
                            {
                                Blocking blocking = new Blocking();
                                blocking.indexator = index;
                                blocking.timeLeft = (int)dataSet1.Tables[0].Rows[i][2];
                                form1.Hide();
                                blocking.Show();
                            }
                        }
                    }
                    
                }
            if (!ifpro)
            {
                string Insert = "Insert into Iter Values (" + 1 + "," + index + ","+0+")";

                OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
                OleDbCommand sql_comm = new OleDbCommand(Insert, sql_conn);
                MessageBox.Show("Неправильный логин или пароль");
                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();
                dataSet1 = new DataSet();
                dataAdapter.Fill(dataSet1,"Iter");
            }
        }
        public int Iterator(string login)
        {
            //duration.ToList().Find((x) => x.login == componentes.login && x.password == componentes.password);
            int index=duration.ToList().FindIndex((x) => x.login == login);

            return index;
        }
        
        public bool IsTrue(int index)
        {
            InitConn();
            //indexator = index;
            bool val=false;
            dataAdapter = new OleDbDataAdapter(CmdText2, ConnectionString);
            dataSet1 = new DataSet();
            int count=dataAdapter.Fill(dataSet1);
            if (count == 0) return true;
            for (int i = 0; i < dataSet1.Tables[0].Rows.Count; i++)
                if ((int)dataSet1.Tables[0].Rows[i][1] == index)
                {
                    if ((int)dataSet1.Tables[0].Rows[i][0] < 3)
                        return val = true;
                    else return val = false;
                }
               // else val = true;
            return val = true;
        }
        public void Timer(int iterator)
        {
            InitConn();
            dataAdapter = new OleDbDataAdapter(CmdText, ConnectionString);
            dataSet1 = new DataSet();
            string Iter;
            if (iterator == 0)
                Iter = "Update Iter Set [Число попыток входа]=0, [Отсчет таймера]=0 Where ID=" + indexator;
            else
                Iter = "Update Iter Set [Отсчет таймера]="+iterator+" Where ID=" + indexator;
            OleDbConnection sql_conn = new OleDbConnection(ConnectionString);
            OleDbCommand sql_comm = new OleDbCommand(Iter, sql_conn);
            sql_conn.Open();
            sql_comm.ExecuteNonQuery();
            sql_conn.Close();
            dataAdapter.Fill(dataSet1, "Iter");
        }
        public int GetIndex(int index)
        {
            for (int i = 0; i < dataSet1.Tables[0].Rows.Count; i++)
            {
                if ((int)dataSet1.Tables[0].Rows[i][1]== index)
                    return i;
            }
            return 0;
        }

    }
}
