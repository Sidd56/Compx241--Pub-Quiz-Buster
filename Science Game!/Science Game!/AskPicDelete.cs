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

namespace Science_Game_
{
    public partial class AskPicDelete : Form
    {
        List<InventionData> deletePics;
        public AskPicDelete(List<InventionData> data)
        {
            InitializeComponent();
            deletePics = data;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            foreach (InventionData s in deletePics)
            {
                foreach (string mFile in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\", "Inventor" + s.DataID + ".png"))
                {
                    File.Delete(mFile);
                    break;
                }

                foreach (string mFile in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\", "Invention" + s.DataID + ".png"))
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
