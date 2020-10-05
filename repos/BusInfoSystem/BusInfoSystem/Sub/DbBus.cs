using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusInfoSystem.Sub
{
    public partial class DbBus : MetroForm
    {
        private readonly string strConnectionString =
           "Data Source=localhost;Port=3306;Database=bus;Uid=root;Password=mysql_p@ssw0rd";
        public DbBus()
        {
            InitializeComponent();
        }

        private void DbBus_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
        
        private void UpdateData()
        {
            using (MySqlConnection conn = new MySqlConnection(strConnectionString)) //Commons.CONNSTR
            {
                string strQuery = "SELECT bstopnm FROM businfo";
                conn.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();//데이터 넣을때
                adapter.Fill(ds, "businfo");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "businfo";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)//데이터는 0이상
            {
                DataGridViewRow data = dataGridView1.Rows[e.RowIndex];
                metroTextBox1.Text = data.Cells[0].Value.ToString();//cells = column, txt개체는 string이라서 value를 tostring으로


                

                
            }
        }
    }
}
