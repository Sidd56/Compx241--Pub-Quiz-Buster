using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pub_Busters___Musical_Bingo
{
    public partial class AskSongDelete : Form
    {
        List<SongData> deleteSongs;
        public AskSongDelete(List<SongData> popData)
        {
            InitializeComponent();
            deleteSongs = popData;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            foreach (SongData s in deleteSongs)
            {
                foreach (string mFile in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\","Song" + s.SongID + ".mp4"))
                {
                    File.Delete(mFile);
                    break;
                }
            }
            Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
