using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySqlDataAdapter = MySql.Data.MySqlClient.MySqlDataAdapter;
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;
using System.Net;

namespace Science_Game_
{
    public partial class Science_Game : Form
    {
        string path = Directory.GetCurrentDirectory() + "//";
        string sql = "select * from Technology";
        List<InventionData> datas;
        bool picFound = false;
        public Science_Game()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            ConnectWithDatabase(sql);
            Inventions i = new Inventions(datas);

            i.ShowDialog();
        }

        /// <summary>
        /// Connecting the MySQL database with this program and creating a new list of results
        /// </summary>
        /// <param name="mySql">The query</param>
        private void ConnectWithDatabase(string mySql)
        {
            datas = new List<InventionData>();
            string connectionstring = @"datasource=sql6.freesqldatabase.com;port=3306;database=sql6417439;username=sql6417439;password=xlUKVETect";
            MySqlDataReader reader = null;
            MySqlConnection conn = new MySqlConnection(connectionstring);
            MySqlCommand command = new MySqlCommand(mySql, conn);
            conn.Open();
            MySql.Data.MySqlClient.MySqlDataAdapter dtb = new MySqlDataAdapter(mySql, conn);
            reader = command.ExecuteReader();
            progressBarLoading.Value = 0;
            while (reader.Read())
            {
                InventionData s = new InventionData(int.Parse(reader.GetString(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), 0, 0);
                picFound = false;
                foreach (string mFile in Directory.GetFiles(path, "Invention" + s.DataID + ".png"))
                {
                    picFound = true;
                    break;
                }

                //Pic not found, so download the mp4 of the song
                if (picFound == false)
                { 
                    DownloadImage(reader.GetString(4), "invention", s.DataID);
                    labelDownload.Visible = true;
                }

                picFound = false;

                foreach (string mFile in Directory.GetFiles(path, "Inventor" + s.DataID + ".png"))
                {
                    picFound = true;
                    break;
                }

                //Pic not found, so download the mp4 of the song
                if (picFound == false)
                {
                    DownloadImage(reader.GetString(3), "inventor", s.DataID);
                    labelDownload.Visible = true;
                }

                datas.Add(s);
                progressBarLoading.Value += 100 / 18;
            }
            progressBarLoading.Value = 100;
            labelDownload.Visible = false;
        }

        private void DownloadImage(string url, string inventionOrInventor, int dataid)
        {
            using (System.Net.WebClient client = new WebClient())
            {
                if (inventionOrInventor == "invention")
                {
                    client.DownloadFile(new Uri(url), "Invention" + dataid + ".png");
                }
                if (inventionOrInventor == "inventor")
                {
                    client.DownloadFile(new Uri(url), "Inventor" + dataid + ".png");
                }
            }
        }
    }
}
