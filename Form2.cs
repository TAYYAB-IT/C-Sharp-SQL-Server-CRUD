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
    public partial class Form2 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        
        public Form2()
        {
            InitializeComponent();
            string connection_str = @"Data Source=DESKTOP-OGKQFUH\SQLEXPRESS;Initial Catalog=Company;Integrated Security=true";
            this.connection = new SqlConnection(connection_str);

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Close();
        }
        //Convert TO Date
        private string convert_to_date(string date)
        {
            string[] str = date.Split('/');
            string month = "";
            switch (Int32.Parse(str[1]))
            {
                case 1:
                    month = "JAN";
                    break;
                case 2:
                    month = "FEB";
                    break;
                case 3:
                    month = "MAR";
                    break;
                case 4:
                    month = "APR";
                    break;
                case 5:
                    month = "MAY";
                    break;
                case 6:
                    month = "JUN";
                    break;
                case 7:
                    month = "JUL";
                    break;
                case 8:
                    month = "AUG";
                    break;
                case 9:
                    month = "SEP";
                    break;
                case 10:
                    month = "OCT";
                    break;
                case 11:
                    month = "NOV";
                    break;
                case 12:
                    month = "DEC";
                    break;
            }
            return (str[0]+" "+month+" "+str[2]);
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            string sql;
            
            if(!string.IsNullOrWhiteSpace(empno.Text) && !string.IsNullOrWhiteSpace(ename.Text)&& !string.IsNullOrWhiteSpace(sal.Text)&& !string.IsNullOrWhiteSpace(hiredate.Text) && !string.IsNullOrWhiteSpace(deptno.Text)&& !string.IsNullOrWhiteSpace(mgr.Text)&& job.SelectedItem!=null)
            {
                try
                {
                    string date = convert_to_date(hiredate.Text);
                    sql = $"Insert into Employee(EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO)" +
                        $"values({empno.Text},'{ename.Text}','{job.SelectedItem}',{mgr.Text},'{date}',{sal.Text},{comm.Text},{deptno.Text})";
                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = command;
                    MessageBox.Show(adapter.InsertCommand.ExecuteNonQuery().ToString() + " New Record Added");
                    connection.Close();
                    empno.Text = ename.Text = sal.Text = hiredate.Text = deptno.Text = mgr.Text = "";
                    comm.Text = "NULL";
                    job.SelectedItem = null;
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

        private void job_SelectedValueChanged(object sender, EventArgs e)
        {
            if (job.SelectedItem == null) { }
             else if (job.SelectedItem.ToString() == "President")
            {
                mgr.Text = "NULL";
            }
            else
            {
                mgr.Text = "";
            }
        }

    }
}
