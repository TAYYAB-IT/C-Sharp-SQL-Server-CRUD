
namespace DB_Conn_01
{
    partial class Form3
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
            this.view_source = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_source)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "EMPLOYEE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // view_source
            // 
            this.view_source.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_source.Location = new System.Drawing.Point(47, 119);
            this.view_source.Name = "view_source";
            this.view_source.Size = new System.Drawing.Size(694, 226);
            this.view_source.TabIndex = 7;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.OrangeRed;
            this.delete.Location = new System.Drawing.Point(190, 380);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 31);
            this.delete.TabIndex = 8;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(494, 380);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(80, 31);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(47, 93);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(126, 20);
            this.id.TabIndex = 10;
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.find.Location = new System.Drawing.Point(190, 93);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(42, 20);
            this.find.TabIndex = 11;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Employee No";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.find);
            this.Controls.Add(this.id);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.view_source);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.view_source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView view_source;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Label label2;
    }
}