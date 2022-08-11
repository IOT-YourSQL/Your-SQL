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
    public partial class DB : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            DB_connect db_connect = new DB_connect();
            db_connect.connection_DB();
            DB_connect.getInst().show_table(this);
            Table_name_Text.SelectedIndexChanged += new System.EventHandler(Table_name_Text_SelectionChanged);
        }

        private void Init_list_view()
        {
            Data_List.BeginUpdate();
            DB_connect.getInst().dataRoad(this);
            Data_List.EndUpdate();
        }

        public DB()
        {
            InitializeComponent();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Data_List.Clear();
            Init_list_view();
        }


        private void Insert_Table_Btn_Click(object sender, EventArgs e)
        {
            //InsertForm Insert_Form = new Insert_Form();
            //Insert_Form.Show();

        }

        private void Create_Table_Btn_Click(object sender, EventArgs e)
        {
            Create_Table create_Table = new Create_Table(this);
            create_Table.Show();
            //DB_connect.getInst().Create_Table(mStatus);
        }

        private void Drop_Table_Btn_Click(object sender, EventArgs e)
        {
            DB_connect.getInst().Drop_Table(this);
        }
        public void show_table()
        {
            DB_connect.getInst().show_table(this);
        }
        public void show_table_Btn_Click(object sender, EventArgs e)
        {
            show_table();
        }
        private void Table_name_Text_SelectionChanged(object sender, EventArgs e)
        {
            Init_list_view();
        }

    }
}
