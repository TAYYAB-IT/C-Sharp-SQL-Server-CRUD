
namespace DB_Conn_01
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ename = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.job = new System.Windows.Forms.ComboBox();
            this.sal = new System.Windows.Forms.MaskedTextBox();
            this.empno = new System.Windows.Forms.MaskedTextBox();
            this.deptno = new System.Windows.Forms.MaskedTextBox();
            this.mgr = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hiredate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "EMPLOYEE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "EMPNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "JOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "HIREDATE";
            // 
            // comm
            // 
            this.comm.Location = new System.Drawing.Point(224, 213);
            this.comm.Name = "comm";
            this.comm.Size = new System.Drawing.Size(189, 20);
            this.comm.TabIndex = 13;
            this.comm.Text = "NULL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "COMM";
            // 
            // ename
            // 
            this.ename.Location = new System.Drawing.Point(527, 65);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(175, 20);
            this.ename.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ENAME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "SAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "DEPTNO";
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(301, 292);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 24;
            this.ADD.Text = "INSERT";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(419, 292);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 25;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // job
            // 
            this.job.FormattingEnabled = true;
            this.job.Items.AddRange(new object[] {
            "Analyst",
            "Clerk",
            "Manager",
            "President",
            "Salesman"});
            this.job.Location = new System.Drawing.Point(224, 116);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(189, 21);
            this.job.TabIndex = 26;
            this.job.SelectedValueChanged += new System.EventHandler(this.job_SelectedValueChanged);
            // 
            // sal
            // 
            this.sal.Location = new System.Drawing.Point(527, 116);
            this.sal.Mask = "0000";
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(175, 20);
            this.sal.TabIndex = 29;
            this.sal.ValidatingType = typeof(int);
            // 
            // empno
            // 
            this.empno.Location = new System.Drawing.Point(224, 65);
            this.empno.Mask = "0000";
            this.empno.Name = "empno";
            this.empno.Size = new System.Drawing.Size(189, 20);
            this.empno.TabIndex = 30;
            this.empno.ValidatingType = typeof(int);
            // 
            // deptno
            // 
            this.deptno.Location = new System.Drawing.Point(527, 163);
            this.deptno.Mask = "00";
            this.deptno.Name = "deptno";
            this.deptno.Size = new System.Drawing.Size(175, 20);
            this.deptno.TabIndex = 31;
            this.deptno.ValidatingType = typeof(int);
            // 
            // mgr
            // 
            this.mgr.Location = new System.Drawing.Point(527, 213);
            this.mgr.Name = "mgr";
            this.mgr.Size = new System.Drawing.Size(175, 20);
            this.mgr.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "MGR";
            // 
            // hiredate
            // 
            this.hiredate.Location = new System.Drawing.Point(224, 163);
            this.hiredate.Mask = "00/00/0000";
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(189, 20);
            this.hiredate.TabIndex = 34;
            this.hiredate.ValidatingType = typeof(System.DateTime);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hiredate);
            this.Controls.Add(this.mgr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deptno);
            this.Controls.Add(this.empno);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.job);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ename);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox comm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox job;
        private System.Windows.Forms.MaskedTextBox sal;
        private System.Windows.Forms.MaskedTextBox empno;
        private System.Windows.Forms.MaskedTextBox deptno;
        private System.Windows.Forms.MaskedTextBox mgr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox hiredate;
    }
}