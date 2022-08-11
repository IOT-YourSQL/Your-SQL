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
    public partial class Create_Table : Form
    {
        private List<string> sequence_list = new List<string>();
        private static DB Main_Form;
        public Create_Table(DB from)
        {
            InitializeComponent();
            sequence_list.Add("");
            Main_Form = from;
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try{
                string sequence_add = sequence_text.Text.ToString() + " " 
                    + sequence_type_text.Text.ToString() + " not null,";
                sequence_list.Add(sequence_add);
                PK_Check.Items.Add(sequence_text.Text.ToString());
                sequence_text.Clear();
            }catch
            {
                Console.WriteLine("Add table Error");
            }
        }

        private void Create_Btn_Click(object sender, EventArgs e)
        {
            if (Table_Text != null)
            {
                sequence_list[0] = "create table " + Table_Text.Text.ToString() +"(";
                sequence_list.Add("PRIMARY KEY(" + PK_Check.SelectedItem.ToString() + "))");
                string query = String.Join("",sequence_list.ToArray());
                DB_connect.getInst().Create_Table(query);
                Main_Form.show_table();
                this.Close();
            }
        }
    }
}
