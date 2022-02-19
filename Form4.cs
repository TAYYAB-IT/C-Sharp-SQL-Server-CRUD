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
    public partial class Form4 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        DataTable table=new DataTable();
        public Form4()
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
        }
        //Find One Record
        private DataRow find_one_by_eno(string eno)
        {

            
            DataRow record = this.table.NewRow();
            try
            {
                conn.Open();
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
            return record;
        }
        private void find_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrWhiteSpace(id.Text))
            {
                    DataRow row = find_one_by_eno(id.Text);
                    if (string.IsNullOrWhiteSpace(row["EMPNO"].ToString()))
                    {
                        MessageBox.Show($"Employee No {id.Text}  not exist in DB!");
                    }
                    else
                    {
                        empno.Text = row["EMPNO"].ToString();
                        ename.Text = row["ENAME"].ToString();
                    job.Text = row["JOB"].ToString();
                      
                    
                        mgr.Text = (string.IsNullOrWhiteSpace(row["MGR"].ToString()))?"NULL":row["MGR"].ToString();
                    
                        hiredate.Text = $"{(row["HIREDATE"])}";
                        sal.Text = row["SAL"].ToString();
                        comm.Text = (string.IsNullOrWhiteSpace(row["COMM"].ToString()))?"NULL":row["COMM"].ToString();
                        deptno.Text = row["DEPTNO"].ToString();
                        update.Visible = true;
                    }
                

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(empno.Text) && !string.IsNullOrWhiteSpace(ename.Text) && !string.IsNullOrWhiteSpace(sal.Text) && !string.IsNullOrWhiteSpace(hiredate.Text) && !string.IsNullOrWhiteSpace(deptno.Text) && !string.IsNullOrWhiteSpace(mgr.Text))
            {
                try
                {
                    string sql = $"Update Employee " +
                            $"set ENAME='{ename.Text}',MGR={mgr.Text},HIREDATE='{hiredate.Text}',SAL={sal.Text},COMM={comm.Text},DEPTNO={deptno.Text} where (EMPNO={empno.Text})";
                    conn.Open();
                    cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.UpdateCommand = cmd;
                    MessageBox.Show(adapter.UpdateCommand.ExecuteNonQuery().ToString() + "  Record Updated");
                    conn.Close();
                    id.Text=job.Text=empno.Text = ename.Text = sal.Text = hiredate.Text = deptno.Text = mgr.Text = "";
                    comm.Text = "";
                  
                    update.Visible = false;
                   
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                MessageBox.Show("Something Missing!");
            }
        }
    }
}
