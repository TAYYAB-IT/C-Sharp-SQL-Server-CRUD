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
    public partial class Form3 : Form
    {
        DataTable table = new DataTable();
        SqlConnection conn;
        SqlCommand cmd;
        public Form3()
        {
            InitializeComponent();
            string connection_str = @"Data Source=DESKTOP-OGKQFUH\SQLEXPRESS;Initial Catalog=Company;Integrated Security=true";
            this.conn = new SqlConnection(connection_str);
            this.table.Columns.Add("EMPNO");
            this.table.Columns.Add("ENAME");
            this.table.Columns.Add("JOB");
            this.table.Columns.Add("MGR");
            this.table.Columns.Add("HIREDATE");
            this.table.Columns.Add("SAL");
            this.table.Columns.Add("COMM");
            this.table.Columns.Add("DEPTNO");
            view_source.DataSource = table;
            view_source.Refresh();
            
        }
        //Find An Record BY ITS ID
        private DataRow find_one_by_eno(string eno)
        {
            
                conn.Open();
                DataRow record = this.table.NewRow();
            try
            {
                string sql = $"Select * from Employee where EMPNO={eno}";
                cmd = new SqlCommand(sql, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {

                    record["EMPNO"] = dataReader.GetValue(0);
                    record["ENAME"] = dataReader.GetValue(1);
                    record["JOB"] = dataReader.GetValue(2);
                    record["MGR"] = dataReader.GetValue(3);
                    record["HIREDATE"] = dataReader.GetValue(4);
                    record["SAL"] = dataReader.GetValue(5);
                    record["COMM"] = dataReader.GetValue(6);
                    record["DEPTNO"] = dataReader.GetValue(7);

                }
                conn.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
                view_source.Refresh();
                return record;
            }
        private void find_Click(object sender, EventArgs e)
        {
            delete.Visible = false;
            this.table.Rows.Clear();
            view_source.Refresh();
            if (!string.IsNullOrWhiteSpace(id.Text))
            {
                
                DataRow row = find_one_by_eno(id.Text);
                if (string.IsNullOrWhiteSpace(row["EMPNO"].ToString())){
                    MessageBox.Show($"Employee No {id.Text}  not exist in DB!");
                }
                else
                {
                   this.table.Rows.Clear();
                   
                    this.table.Rows.Add(row);
                    view_source.Refresh();
                    delete.Visible = true;
                }
                
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE from Employee where EMPNO={this.table.Rows[0]["EMPNO"]}";
                cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = cmd;
                MessageBox.Show(adapter.DeleteCommand.ExecuteNonQuery().ToString() + "  Rows Deleted!");
                this.table.Rows.Clear();
                view_source.Refresh();
                id.Text = "";
                delete.Visible = false;
                conn.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
