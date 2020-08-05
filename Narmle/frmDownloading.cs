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

namespace Narmle
{
    public partial class frmDownloading : Form
    {
        public string romsPath = "";
        public List<string> games;

        public frmDownloading(string romsPath, List<string> extensions)
        {
            InitializeComponent();
            this.romsPath = romsPath;

            string[] names = Directory.GetFiles(romsPath);

            foreach (string name in names)
                if (extensions.Contains(Path.GetExtension(name)))
                    games.Add(Path.GetFileNameWithoutExtension(name));
        }

        private void frmDownloading_Load(object sender, EventArgs e)
        {
            
        }
    }
}
