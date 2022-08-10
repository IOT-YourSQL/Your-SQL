
namespace WF1
{
    partial class Create_Table
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
            this.Table_Text = new System.Windows.Forms.TextBox();
            this.Create_Btn = new System.Windows.Forms.Button();
            this.sequence_text = new System.Windows.Forms.TextBox();
            this.sequence_type_text = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.PK_Check = new System.Windows.Forms.CheckedListBox();
            this.PK_Check_labe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Table_Text
            // 
            this.Table_Text.Location = new System.Drawing.Point(34, 35);
            this.Table_Text.Name = "Table_Text";
            this.Table_Text.Size = new System.Drawing.Size(100, 21);
            this.Table_Text.TabIndex = 0;
            // 
            // Create_Btn
            // 
            this.Create_Btn.Location = new System.Drawing.Point(255, 139);
            this.Create_Btn.Name = "Create_Btn";
            this.Create_Btn.Size = new System.Drawing.Size(75, 23);
            this.Create_Btn.TabIndex = 2;
            this.Create_Btn.Text = "생성";
            this.Create_Btn.UseVisualStyleBackColor = true;
            this.Create_Btn.Click += new System.EventHandler(this.Create_Btn_Click);
            // 
            // sequence_text
            // 
            this.sequence_text.Location = new System.Drawing.Point(34, 80);
            this.sequence_text.Name = "sequence_text";
            this.sequence_text.Size = new System.Drawing.Size(100, 21);
            this.sequence_text.TabIndex = 3;
            // 
            // sequence_type_text
            // 
            this.sequence_type_text.FormattingEnabled = true;
            this.sequence_type_text.Items.AddRange(new object[] {
            "INT",
            "varchar(50)"});
            this.sequence_type_text.Location = new System.Drawing.Point(156, 81);
            this.sequence_type_text.Name = "sequence_type_text";
            this.sequence_type_text.Size = new System.Drawing.Size(80, 20);
            this.sequence_type_text.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "테이블 명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "시퀀스";
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(255, 78);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Btn.TabIndex = 8;
            this.Add_Btn.Text = "추가";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // PK_Check
            // 
            this.PK_Check.FormattingEnabled = true;
            this.PK_Check.Location = new System.Drawing.Point(36, 127);
            this.PK_Check.Name = "PK_Check";
            this.PK_Check.Size = new System.Drawing.Size(200, 100);
            this.PK_Check.TabIndex = 9;
            // 
            // PK_Check_labe
            // 
            this.PK_Check_labe.AutoSize = true;
            this.PK_Check_labe.Location = new System.Drawing.Point(34, 112);
            this.PK_Check_labe.Name = "PK_Check_labe";
            this.PK_Check_labe.Size = new System.Drawing.Size(81, 12);
            this.PK_Check_labe.TabIndex = 10;
            this.PK_Check_labe.Text = "프라이머리 키";
            // 
            // Create_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 235);
            this.Controls.Add(this.PK_Check_labe);
            this.Controls.Add(this.PK_Check);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sequence_type_text);
            this.Controls.Add(this.sequence_text);
            this.Controls.Add(this.Create_Btn);
            this.Controls.Add(this.Table_Text);
            this.Name = "Create_Table";
            this.Text = "테이블 생성";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Table_Text;
        private System.Windows.Forms.Button Create_Btn;
        private System.Windows.Forms.TextBox sequence_text;
        private System.Windows.Forms.ComboBox sequence_type_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.CheckedListBox PK_Check;
        private System.Windows.Forms.Label PK_Check_labe;
    }
}