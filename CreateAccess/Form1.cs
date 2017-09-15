using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Management;
using System.Linq;
using System.Drawing;

namespace CreateAccess
{
    public partial class Form1 : Form
    {
        OleDbConnection myConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\ErrorCodeDataBase.mdb;User ID=Admin");
        private string[] table = new string[20];
        private List<string> lProcessName = new List<string>();
        public Form1()
        {
            InitializeComponent();
            myConnection.Open();
            Refresh_Combobox();
            //listView1.DrawMode = DrawMode.OwnerDrawFixed;
            //listView1.DrawItem += new DrawItemEventHandler(drawEvent);
            dataGridView1.AllowUserToAddRows = false;
            listView1.TileSize = new Size(listView1.Width,15 );



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (Createtb.Text != "" & listView1.Items.Count != 0 & Time.Text != "" & Remark.Text != "")
            {
                DataTable Tables = myConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                foreach (DataRow row in Tables.Rows)
                {
                    if (Createtb.Text == row[2].ToString()) 
                    {
                        string deletetable = string.Format("DROP TABLE [{0}]", Createtb.Text);
                        OleDbCommand myComm = new OleDbCommand(deletetable, myConnection);
                        myComm.ExecuteNonQuery();
                    }
                }

                string AccessTable = "CREATE TABLE [" + Createtb.Text + "]([Error Name] string,[Error Code] int)";
                OleDbCommand myCommand = new OleDbCommand(AccessTable, myConnection);
                myCommand.ExecuteNonQuery();
                int Error_Code = 1;

                String strSQ = " INSERT INTO [Tableinfo] ([修改日期], [備註]) VALUES ('" + Time.Text + "','" + Remark.Text + "')";
                OleDbCommand myCommd = new OleDbCommand(strSQ, myConnection);
                myCommd.ExecuteNonQuery();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    String strSQL = " INSERT INTO [" + Createtb.Text + "] ([Error Name], [Error Code]) VALUES ('" + listView1.Items[i].Text + "','" + Error_Code + "')";
                    OleDbCommand myComman = new OleDbCommand(strSQL, myConnection);
                    myComman.ExecuteNonQuery();
                    Error_Code++;
                }
                Refresh_Combobox();
                MessageBox.Show("創建修改完成，加入修改日期、備註", "成功", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("請檢查Table名稱、修改日期、備註、Listbox是否為空白", "錯誤", MessageBoxButtons.OKCancel);
            }   
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            myConnection.Close();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Refresh_Combobox();
        }

        private void Refresh_Combobox()
        {
            myConnection.Close();
            myConnection.Open();
            if (Inquiretb.Items.Count != 0)
            {
                Inquiretb.Items.Clear();
                Modifytb.Items.Clear();
            }
            DataTable Tables = myConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            int table_count = 0;
            foreach (DataRow row in Tables.Rows)
            {
                table[table_count] = row[2].ToString();
                if (table[table_count] != "貼上錯誤")//TODO:table的判斷
                {
                    Inquiretb.Items.Add(table[table_count]);

                    if (table[table_count] != "Tableinfo" & table[table_count] != "Option")
                    {
                        Modifytb.Items.Add(table[table_count]);
                    }
                }
                table_count++;
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cdtime.Text) < 5)
            {
                cdtime.Text = "5";
            }
            String strproduct = @"Update [Option] SET [Product]='" + Modifytb.Text + "'";
            String strcountdowntime = @"Update [Option] SET [CountdownTime]='" + cdtime.Text + "'";
            OleDbCommand myComman = new OleDbCommand(strproduct, myConnection);
            myComman.ExecuteNonQuery();
            OleDbCommand myCommand = new OleDbCommand(strcountdowntime, myConnection);
            myCommand.ExecuteNonQuery();
            string command = "select * from [Option]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(command, myConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Inquiretb.SelectedItem = "Option";
            MessageBox.Show("修改完成", "成功", MessageBoxButtons.OKCancel);
        }

        private void cdtime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cdtime.Text.Length < 3)
            {
                if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
                {
                    e.Handled = true;
                    MessageBox.Show("輸入錯誤字元", "錯誤", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                if ((int)e.KeyChar != 8)
                {
                    e.Handled = true;
                    MessageBox.Show("輸入字串過長", "錯誤", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void Inquiretb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection con1 = myConnection;
            string sql1 = "select * from [" + Inquiretb.Text + "]";
            OleDbDataAdapter ad1 = new OleDbDataAdapter(sql1, con1);
            DataSet ds1 = new DataSet();
            ad1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AllowUserToResizeColumns = true;
           foreach(ListViewItem item in listView1.Items)
            {
                item.ForeColor = Color.Black;
            }
        }

        private void updatelist_Click(object sender, EventArgs e)
        {
            if (lProcessName.Count != 0)
            {
                listView1.Items.Clear();
                lProcessName.Clear();
            }
            ManagementScope scope = new ManagementScope("\\\\.\\ROOT\\cimv2");
            ObjectQuery query = new ObjectQuery("SELECT * FROM  Win32_PnPEntity");
            ManagementObjectSearcher searchar = new ManagementObjectSearcher(scope, query);
            ManagementObjectCollection queryCollection = searchar.Get();

            foreach (ManagementObject Obj in searchar.Get())
            {
                if (Obj["Name"] != null && Obj["Status"].ToString() == "OK")
                {
                    lProcessName.Add(Obj["Name"].ToString().Trim());
                    lProcessName.Sort();
                //Remark.Text = Obj["Name"].ToString().Trim()+Remark.Text;
                }
            }

            for (int i = 0; i < lProcessName.Count; i++)
            {
                int _list_index = lProcessName.IndexOf(lProcessName[i]);
                int value = (i - _list_index) + 1;
                listView1.Items.Add(lProcessName[i] + " " + value);
            }
            
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("請先更新本機資料", "操作錯誤", MessageBoxButtons.OK);
            }
            else
            {
                lProcessName.RemoveAt(listView1.SelectedItems[0].Index);
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Createtb.Text != "" & Remark.Text != "")
            {
                DataTable Tables = myConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                foreach (DataRow row in Tables.Rows)
                {
                    if (Createtb.Text == row[2].ToString())
                    {
                        string deletetable = string.Format("DROP TABLE {0}", Createtb.Text);
                        OleDbCommand myComm = new OleDbCommand(deletetable, myConnection);
                        myComm.ExecuteNonQuery();
                    }
                }
                string deletetableinfo = string.Format("DELETE * FROM Tableinfo WHERE [備註] = '" + Remark.Text + "'");
                OleDbCommand myCommd = new OleDbCommand(deletetableinfo, myConnection);
                myCommd.ExecuteNonQuery();
                Refresh_Combobox();
                MessageBox.Show("刪除Table完成", "完成", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("請檢查Table名稱是否為空白", "錯誤", MessageBoxButtons.OKCancel);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void RemoveData_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            
            if(dataGridView1.Columns.Count >= 2 && dataGridView1.Columns[1].Name.Equals("Error Code"))
            {
                int errorCode = 1;
                foreach(DataGridViewRow item in dataGridView1.Rows)
                {
                    item.Cells[1].Value=errorCode;
                    errorCode++;
                }
            }
            
        }

        private void ModifyTable_Click(object sender, EventArgs e)
        {
            if(Inquiretb.SelectedItem == null)
            {
                MessageBox.Show("請先選擇表單", "操作錯誤", MessageBoxButtons.OK);
            }
            else if(dataGridView1.SelectedCells.Count > 1)
            {
                MessageBox.Show("請選擇一個項目", "操作錯誤", MessageBoxButtons.OK);
            }
            else if(Inquiretb.SelectedItem.ToString().Equals("Option")||Inquiretb.SelectedItem.ToString().Equals("Countdown"))
            {
                MessageBox.Show("請選擇別的表單", "操作錯誤", MessageBoxButtons.OK);
            }
            else if(dataGridView1.Columns[0].ValueType == typeof(string) && dataGridView1.Columns[1].ValueType == typeof(int))
            {
                int value;
                if(dataGridView1.SelectedCells[0].Value.GetType() == typeof(int))
                {
                    if (int.TryParse(ModifyData.Text, out value))
                    {
                        if (value <= dataGridView1.Rows.Count && value >= 1)
                        {
                            dataGridView1.SelectedCells[0].Value = value;
                            int cellIndex = dataGridView1.SelectedCells[0].RowIndex;

                            if (cellIndex > value)
                            {
                                for (int i = value - 1; i < cellIndex; i++)
                                {
                                    int v = (int)dataGridView1.Rows[i].Cells[1].Value;
                                    v++;
                                    dataGridView1.Rows[i].Cells[1].Value = v;
                                }
                            }
                            else if (cellIndex < value)
                            {
                                for (int i = cellIndex + 1; i <= value - 1; i++)
                                {
                                    int v = (int)dataGridView1.Rows[i].Cells[1].Value;
                                    v--;
                                    dataGridView1.Rows[i].Cells[1].Value = v;
                                }
                            }
                            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
                        }
                        else
                            MessageBox.Show("請輸入小於Error Code最大值的數或大於1的值", "操作錯誤", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("請輸入一個整數", "操作錯誤", MessageBoxButtons.OK);
                    }
                }
                else if (ModifyData.Text.Trim().Equals(""))
                {
                    MessageBox.Show("請勿輸入空白", "操作錯誤", MessageBoxButtons.OK);
                }
                else
                {
                    dataGridView1.SelectedCells[0].Value = ModifyData.Text.Trim();
                }
                
            }
            else if(dataGridView1.Columns[0].ValueType == typeof(DateTime) && dataGridView1.Columns[1].ValueType == typeof(string))
            {
                DateTime date;
                if(dataGridView1.SelectedCells[0].ValueType == typeof(DateTime))
                {
                    if (DateTime.TryParse(ModifyData.Text, out date))
                    {
                        dataGridView1.SelectedCells[0].Value = ModifyData.Text;
                    }
                    else
                        MessageBox.Show("請輸入日期格式", "操作錯誤", MessageBoxButtons.OK);
                }
                else
                {
                    dataGridView1.SelectedCells[0].Value = ModifyData.Text;
                }
                
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("請先更新本機資料", "操作錯誤", MessageBoxButtons.OK);
            }
            else if (dataGridView1.Columns.Count >= 2 && dataGridView1.Columns[1].Name.Equals("Error Code"))
            {
                int processIndex = listView1.SelectedItems[0].Index;
                string process = lProcessName[processIndex];
                int count = 1;
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string tmp = string.Format("{0} {1}", process, count);
                    if (dataGridView1.Rows[i].Cells[0].Value.Equals(tmp))
                    {
                        count++;
                    }
                }
                int lastCode = dataGridView1.Rows.Count;
                DataTable ds = (DataTable)dataGridView1.DataSource;
                string newRow = string.Format("{0} {1}", process, count);
                ds.Rows.Add(new Object[] { newRow, lastCode });
            }
            else
            {
                MessageBox.Show("請選擇別的表單", "操作錯誤", MessageBoxButtons.OK);
            }
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Inquiretb.SelectedItem == null)
            {
                MessageBox.Show("請先選擇表單", "操作錯誤", MessageBoxButtons.OK);
                return;
            }

            string delCommand = string.Format("drop table [{0}]", Inquiretb.SelectedItem);
            OleDbCommand olecommand = new OleDbCommand(delCommand, myConnection);

            if(!Inquiretb.SelectedItem.ToString().Equals("Countdown") && !Inquiretb.SelectedItem.ToString().Equals("Option"))
            {
                olecommand.ExecuteNonQuery();
            }

            if (dataGridView1.Columns.Count > 1 && dataGridView1.Columns[0].Name.Equals("Error Name"))
            {
                string createCommand = string.Format("create table [{0}]([Error Name] string, [Error Code] int)",
                    Inquiretb.SelectedItem);
                olecommand.CommandText = createCommand;
                olecommand.ExecuteNonQuery();


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string insertCommand = string.Format("insert into [{0}] ([Error Name],[Error Code]) values('{1}','{2}')"
                        , Inquiretb.SelectedItem, row.Cells[0].Value, row.Cells[1].Value);
                    olecommand.CommandText = insertCommand;
                    olecommand.ExecuteNonQuery();
                }
            }
            else if (Inquiretb.SelectedItem.Equals("Tableinfo"))
            {
                string createCommand = "create table [Tableinfo]([修改日期] DateTime, [備註] string)";
                olecommand.CommandText = createCommand;
                olecommand.ExecuteNonQuery();
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                foreach (DataRow row in dataTable.Rows)
                {
                    string insertCommand = string.Format("insert into [Tableinfo] ([修改日期], [備註]) values('{0}','{1}')",
                        row.ItemArray[0], row.ItemArray[1]);
                    olecommand.CommandText = insertCommand;
                    olecommand.ExecuteNonQuery();
                }
            }
            string selectCommand = string.Format("select * from [{0}]", Inquiretb.SelectedItem);
            OleDbDataAdapter adapter = new OleDbDataAdapter(selectCommand, myConnection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void ComparTable_Click(object sender, EventArgs e)
        {
            if(Inquiretb.SelectedItem == null)
            {
                MessageBox.Show("請選擇表單", "操作錯誤", MessageBoxButtons.OK);
            }
            else if(listView1.Items.Count == 0)
            {
                MessageBox.Show("請先更新本機資料", "操作錯誤", MessageBoxButtons.OK);
            }
            else
            {
                List<string> access = new List<string>();
                List<string> driverName = new List<string>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    access.Add(row.Cells[0].Value.ToString());
                }

                foreach (ListViewItem item in listView1.Items)
                {
                    driverName.Add(item.Text);
                }

                var except = access.Except(driverName);
                foreach (string s in except.ToList())
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[0].Value.Equals(s))
                        {
                            row.Cells[0].Style.BackColor = Color.Red;
                            row.Cells[1].Style.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void Compar_Click(object sender, EventArgs e)
        {
            if(Inquiretb.SelectedItem == null)
            {
                MessageBox.Show("請選擇表單", "操作錯誤", MessageBoxButtons.OK);
            }
            else if(listView1.Items.Count == 0)
            {
                MessageBox.Show("請先更新本機資料", "操作錯誤", MessageBoxButtons.OK);
            }
            else
            {
                //DataTable dataTable = (DataTable)dataGridView1.DataSource;
                List<string> access = new List<string>();
                List<string> driverName = new List<string>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    access.Add(row.Cells[0].Value.ToString());
                }

                foreach (ListViewItem item in listView1.Items)
                {
                    driverName.Add(item.Text);
                }

                var execpt2 = driverName.Except(access);

                foreach (string s in execpt2.ToList())
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (driverName[i].Equals(s))
                        {
                            listView1.Items[i].ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

    }
}
 