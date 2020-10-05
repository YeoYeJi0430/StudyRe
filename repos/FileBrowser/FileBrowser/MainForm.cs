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

namespace FileBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TreeNode root = TvFolder.Nodes.Add("내컴퓨터");

            string[] drives = Directory.GetLogicalDrives(); //Directory 클래스 사용시 빨간줄 -> Alt+Enter 이용해서 수정 
            foreach (string drive in drives)
            {
                TreeNode node = root.Nodes.Add(drive);
                node.Nodes.Add("...");
            }

        }

        private void TvFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void TvFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

        }
    }
}
