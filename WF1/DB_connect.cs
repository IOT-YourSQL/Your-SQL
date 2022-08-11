using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WF1
{
    class DB_connect
    {
        static DB_connect mInst;
        static MySqlConnection conn;
        static MySqlCommand cmd;
        static MySqlDataReader data_reader;
        public DB_connect()
        {

            try
            {
                conn = connection_DB();
                cmd = new MySqlCommand();
                conn.Open();
                Console.WriteLine("MySql오픈 성공");
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        public MySqlConnection connection_DB()
        {

            System.String db =
                "Server = localhost;" +
                "Database = bibidi;" +
                "Uid = root;" +
                "Pwd = 1234;";
            return new MySqlConnection(db);
        }
        public void dataRoad(DB from)
        {
            from.Data_List.Clear();
            from.Data_List.View = View.Details;
            int col_count = 0;
            var item_list = new ListViewItem();
            cmd.Connection = conn;
            cmd.CommandText = "select * from "+from.Table_name_Text.Text.ToString();
            cmd.CommandType = System.Data.CommandType.Text;
            data_reader = cmd.ExecuteReader();
            if (data_reader.HasRows)
            {
                while (data_reader.Read())
                {
                    var items = new List<string>();
                    for (; col_count < data_reader.FieldCount; col_count++)
                    {
                        from.Data_List.Columns.Add(data_reader.GetName(col_count).ToString());
                    }

                    Object[] item = new Object[data_reader.FieldCount];
                    int fieldCount = data_reader.GetValues(item);
                    for (int i = 0; i < fieldCount; i++)
                    {
                        items.Add(item[i].ToString());
                    }
                    item_list = new ListViewItem(items.ToArray());
                    from.Data_List.Items.Add(item_list);
                }
            }
            else
            {
                Console.WriteLine("Data is empty");
            }
            data_reader.Close();
        }
        public static DB_connect getInst()
        {
            if(mInst == null)
            {
                mInst = new DB_connect();
            }
            return mInst;
        }

        public void Create_Table(string query)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블 생성 및 시퀀스 생성 완료!");
                Console.WriteLine("query : " + query);
            }
            catch (MySqlException e)
            {
                Console.WriteLine("테이블 생성 Error: " + e.Message);
            }
        }
        public void Drop_Table(DB from)
        {
            Console.WriteLine(from.Table_name_Text.Text.ToString());
            try
            {
                string query = "drop table " + from.Table_name_Text.Text.ToString();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블 삭제 및 시퀀스 삭제 완료!");
            }
            catch (MySqlException e)
            {
                Console.WriteLine("테이블 삭제 Error: " + e.Message);
            }
            show_table(from);
        }
        public void insert_Create_index(string query)
        {
            try{
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블 인덱스 생성 완료!");
            }
            catch (MySqlException e)
            {
                Console.WriteLine("테이블 인덱스 Error: " + e.Message);
            }
        }
        public void show_table(DB from)
        {
            var list = new List<string>();
            from.Table_name_Text.Items.Clear();
            cmd.Connection = conn;
            cmd.CommandText = "SHOW TABLES";
            cmd.CommandType = System.Data.CommandType.Text;
            data_reader = cmd.ExecuteReader();

            if (data_reader.HasRows)
            { 
                while (data_reader.Read())
                {
                    from.Table_name_Text.Text = data_reader.GetValue(0).ToString();
                    for (int col_count = 0; col_count < data_reader.FieldCount; col_count++)
                    {
                        from.Table_name_Text.Items.Add(data_reader.GetValue(col_count).ToString());
                    }
                }
            }
            data_reader.Close();
        }
    }
}
