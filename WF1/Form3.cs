using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class Form3 : Form
    {
        private static DB main_form;
        public string tbl_name { get; set; }
        public Form3(DB form, string tbl_name)
        {
            InitializeComponent();
            main_form = form;
            init_type_box();
            tblname_label.Text = tbl_name;
            this.tbl_name = tbl_name;
            DB_connect.getInst().show_col(this);
        }

        public void init_type_box()
        {
            string[] data = { "INT", "VARCHAR(45)" };
            type_box.Items.AddRange(data);
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = "ALTER TABLE `bibidi`." + tbl_name + " ADD COLUMN " + col_text.Text.ToString() + " "
                            + type_box.Text.ToString() + " NOT NULL";
            DB_connect.getInst().Create_Table(query);
            col_list.Items.Add(col_text.Text);
            col_text.Clear();
            type_box.Text = "";
            main_form.Init_list_view();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            string query = "ALTER TABLE `bibidi`." + tbl_name + " DROP COLUMN " + col_text.Text.ToString();
            Console.WriteLine(query);
            DB_connect.getInst().Create_Table(query);
            col_list.Items.Clear();
            DB_connect.getInst().show_col(this);
            col_text.Clear();
            type_box.Text = "";
            main_form.Init_list_view();
        }

        private void col_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            col_text.Text = col_list.Text;
        }

        private void alter_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
