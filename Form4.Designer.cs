
namespace DB_Conn_01
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mgr = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deptno = new System.Windows.Forms.MaskedTextBox();
            this.empno = new System.Windows.Forms.MaskedTextBox();
            this.sal = new System.Windows.Forms.MaskedTextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ename = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hiredate = new System.Windows.Forms.TextBox();
            this.job = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Employee No";
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.find.Location = new System.Drawing.Point(195, 90);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(42, 20);
            this.find.TabIndex = 15;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(47, 90);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(126, 20);
            this.id.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "EMPLOYEE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mgr
            // 
            this.mgr.Location = new System.Drawing.Point(427, 294);
            this.mgr.Name = "mgr";
            this.mgr.Size = new System.Drawing.Size(175, 20);
            this.mgr.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "MGR";
            // 
            // deptno
            // 
            this.deptno.Location = new System.Drawing.Point(427, 244);
            this.deptno.Mask = "00";
            this.deptno.Name = "deptno";
            this.deptno.Size = new System.Drawing.Size(175, 20);
            this.deptno.TabIndex = 49;
            this.deptno.ValidatingType = typeof(int);
            // 
            // empno
            // 
            this.empno.Location = new System.Drawing.Point(124, 146);
            this.empno.Mask = "0000";
            this.empno.Name = "empno";
            this.empno.ReadOnly = true;
            this.empno.Size = new System.Drawing.Size(189, 20);
            this.empno.TabIndex = 48;
            this.empno.ValidatingType = typeof(int);
            // 
            // sal
            // 
            this.sal.Location = new System.Drawing.Point(427, 197);
            this.sal.Mask = "0000";
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(175, 20);
            this.sal.TabIndex = 47;
            this.sal.ValidatingType = typeof(int);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(319, 373);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 29);
            this.cancel.TabIndex = 45;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ControlDark;
            this.update.Location = new System.Drawing.Point(201, 373);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 29);
            this.update.TabIndex = 44;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Visible = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "DEPTNO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "SAL";
            // 
            // ename
            // 
            this.ename.Location = new System.Drawing.Point(427, 146);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(175, 20);
            this.ename.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "ENAME";
            // 
            // comm
            // 
            this.comm.Location = new System.Drawing.Point(124, 294);
            this.comm.Name = "comm";
            this.comm.Size = new System.Drawing.Size(189, 20);
            this.comm.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "COMM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "HIREDATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "JOB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "EMPNO";
            // 
            // hiredate
            // 
            this.hiredate.Location = new System.Drawing.Point(124, 244);
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(189, 20);
            this.hiredate.TabIndex = 52;
            // 
            // job
            // 
            this.job.Location = new System.Drawing.Point(124, 196);
            this.job.Name = "job";
            this.job.ReadOnly = true;
            this.job.Size = new System.Drawing.Size(189, 20);
            this.job.TabIndex = 53;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.job);
            this.Controls.Add(this.hiredate);
            this.Controls.Add(this.mgr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deptno);
            this.Controls.Add(this.empno);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ename);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.find);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mgr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox deptno;
        private System.Windows.Forms.MaskedTextBox empno;
        private System.Windows.Forms.MaskedTextBox sal;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox comm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hiredate;
        private System.Windows.Forms.TextBox job;
    }
}