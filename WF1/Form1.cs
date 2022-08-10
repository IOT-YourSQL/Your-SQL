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
            Init_list_view();
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
            Data_List.Items.Clear();
            Init_list_view();
        }

        private void 엑셀로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Insert_Table_Btn_Click(object sender, EventArgs e)
        {
            //InsertForm Insert_Form = new Insert_Form();
            //Insert_Form.Show();

        }

        private void Create_Table_Btn_Click(object sender, EventArgs e)
        {
            Create_Table create_Table = new Create_Table();
            create_Table.Show();
            //DB_connect.getInst().Create_Table(mStatus);
        }

        private void Drop_Table_Btn_Click(object sender, EventArgs e)
        {
            DB_connect.getInst().Drop_Table(mStatus);
        }
    }
}
