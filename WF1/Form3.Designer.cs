
namespace WF1
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
            this.col_list = new System.Windows.Forms.ListBox();
            this.col_text = new System.Windows.Forms.TextBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.alter_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.tblname_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // col_list
            // 
            this.col_list.FormattingEnabled = true;
            this.col_list.ItemHeight = 12;
            this.col_list.Location = new System.Drawing.Point(12, 47);
            this.col_list.Name = "col_list";
            this.col_list.Size = new System.Drawing.Size(335, 160);
            this.col_list.TabIndex = 0;
            this.col_list.SelectedIndexChanged += new System.EventHandler(this.col_list_SelectedIndexChanged);
            // 
            // col_text
            // 
            this.col_text.Location = new System.Drawing.Point(57, 214);
            this.col_text.Name = "col_text";
            this.col_text.Size = new System.Drawing.Size(163, 21);
            this.col_text.TabIndex = 1;
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(117, 244);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 2;
            this.insert_btn.Text = "추가";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // alter_btn
            // 
            this.alter_btn.Location = new System.Drawing.Point(198, 244);
            this.alter_btn.Name = "alter_btn";
            this.alter_btn.Size = new System.Drawing.Size(75, 23);
            this.alter_btn.TabIndex = 3;
            this.alter_btn.Text = "수정";
            this.alter_btn.UseVisualStyleBackColor = true;
            this.alter_btn.Click += new System.EventHandler(this.alter_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(279, 244);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 23);
            this.del_btn.TabIndex = 4;
            this.del_btn.Text = "삭제";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // type_box
            // 
            this.type_box.FormattingEnabled = true;
            this.type_box.Location = new System.Drawing.Point(226, 214);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(121, 20);
            this.type_box.TabIndex = 5;
            // 
            // tblname_label
            // 
            this.tblname_label.AutoSize = true;
            this.tblname_label.Location = new System.Drawing.Point(12, 21);
            this.tblname_label.Name = "tblname_label";
            this.tblname_label.Size = new System.Drawing.Size(38, 12);
            this.tblname_label.TabIndex = 6;
            this.tblname_label.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 275);
            this.Controls.Add(this.tblname_label);
            this.Controls.Add(this.type_box);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.alter_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.col_text);
            this.Controls.Add(this.col_list);
            this.Name = "Form3";
            this.Text = "테이블 수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox col_text;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button alter_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.Label tblname_label;
        public System.Windows.Forms.ListBox col_list;
    }
}