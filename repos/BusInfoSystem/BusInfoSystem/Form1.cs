using BusInfoSystem.Sub;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusInfoSystem
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BusTile_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            SearchBus search = new SearchBus();
            search.ShowDialog();

            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            SearchInfo searchinfo = new SearchInfo();
            searchinfo.ShowDialog();

            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
