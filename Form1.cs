using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Conn_01
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        SqlConnection connection;
        SqlCommand command;
       
        public Form1()
        {

            InitializeComponent();
           
            string connection_str= @"Data Source=DESKTOP-OGKQFUH\SQLEXPRESS;Initial Catalog=Company;Integrated Security=true";
            this.connection = new SqlConnection(connection_str);
            this.table.Columns.Add("SR#");
            this.table.Columns.Add("ENO");
            this.table.Columns.Add("ENAME");
            this.table.Columns.Add("JOB");
            this.table.Columns.Add("MGR");
            this.table.Columns.Add("HIREDATE");
            this.table.Columns.Add("SAL");
            this.table.Columns.Add("COMM");
            this.table.Columns.Add("DEPTNO");
            view_source.DataSource = table;
            view_source.Refresh();
            this.Read_DATABASE();
        }
        //Read Data From DATABASE
        private void Read_DATABASE()
        {
            try {
                int i = 1;
                string sql;
                SqlDataReader dataReader;
                sql = "Select * from Employee";
                command = new SqlCommand(sql, this.connection);
                this.connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    DataRow record = this.table.NewRow();
                    record["SR#"] = i;
                    record["ENO"] = dataReader.GetValue(0);
                    record["ENAME"] = dataReader.GetValue(1);
                    record["JOB"] = dataReader.GetValue(2);
                    record["MGR"] = dataReader.GetValue(3);
                    record["HIREDATE"] = dataReader.GetValue(4);
                    record["SAL"] = dataReader.GetValue(5);
                    record["COMM"] = dataReader.GetValue(6);
                    record["DEPTNO"] = dataReader.GetValue(7);
                    this.table.Rows.Add(record);
                    i++;
                }
                view_source.Refresh();
                this.connection.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            }

        private void Insert_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.Show();
            this.Hide();
        }
    }
}
