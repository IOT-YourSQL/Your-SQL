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
            int count = 1;
            cmd.Connection = conn;
            cmd.CommandText = "select * from items order by num asc";
            cmd.CommandType = System.Data.CommandType.Text;
            data_reader = cmd.ExecuteReader();
            if (data_reader.HasRows)
            {
                while (data_reader.Read())
                {
                    from.Data_List.Items.Add(new ListViewItem(new string[]
                        {
                            (count).ToString(),
                            data_reader["name"].ToString(),
                            data_reader["price"].ToString()
                        }));
                    count++;

                }

                from.Data_List.Items[count - 2].Selected = true;
                from.Data_List.Items[count - 2].Focused = true;
                from.Data_List.Focus();
                from.Data_List.EnsureVisible(count - 2);
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
        public void Drop_Table(Label label)
        {
            try
            {
                string query = "drop table member";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                label.Text = "테이블 삭제 및 시퀀스 삭제 완료!";
            }
            catch (MySqlException e)
            {
                label.Text = "테이블  Error :" + e.Message;
            }
        }
    }
}
