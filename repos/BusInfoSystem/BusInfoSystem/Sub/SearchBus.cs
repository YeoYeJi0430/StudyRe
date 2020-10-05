using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BusInfoSystem.Sub
{
    public partial class SearchBus : MetroForm
    {
        private readonly string strConnectionString =
           "Data Source=localhost;Port=3306;Database=bus;Uid=root;Password=mysql_p@ssw0rd";

        public SearchBus()
        {
            InitializeComponent();
        }

        private void SearchBus_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)//데이터는 0이상
            {
                DataGridViewRow data = dataGridView1.Rows[e.RowIndex];
                metroTextBox1.Text = data.Cells[0].Value.ToString();//cells = column, txt개체는 string이라서 value를 tostring으로
            }
        }

        private void HomeBt_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            this.Close();
        }

        private void BusSearchBt_Click(object sender, EventArgs e)
        {
            WebClient web = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();

            //정류소명 검색-> gps ,정류소구분
            //http://61.43.246.153/openapi-data/service/busanBIMS2/busStop?ServiceKey=qexPs8LeXjOa6LAjpXww4Hj1sUYBqYhvT%2F9PQnZs40ZVjgSkaK7kVy%2FdKo2Z7lB5EUBzZ2XB7mGnMiQcxtSgDg%3D%3D
            str.Append("http://61.43.246.153/openapi-data/service/busanBIMS2/busStop");
            str.Append("?ServiceKey=qexPs8LeXjOa6LAjpXww4Hj1sUYBqYhvT%2F9PQnZs40ZVjgSkaK7kVy%2FdKo2Z7lB5EUBzZ2XB7mGnMiQcxtSgDg%3D%3D");
            str.Append($"&bstopnm={metroTextBox1.Text}");//정류소이름
            str.Append("&pageNo=1");                    //페이지번호
            str.Append("&numOfRows = 200");              //한페이지결과수
            
            /*
            str.Append($"&bstopnm=200");                  //정류소명
            
            str.Append($"&arsno={metroTextBox1.Text}"); //정류소번호
            
            str.Append("&lineid=5200179000");//노선ID
            str.Append("&lineno=179");//노선번호
            str.Append($"&companyid ={metroTextBox1.Text} ");
            */
            string xml = web.DownloadString(str.ToString());

            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");

            dataView.Rows.Clear();

            foreach (XmlNode item in items) //items는 리스트
            {
                /*
                dataView.Rows.Add(item["bstopNm"].InnerText,
                                  item["bstopArsno"].InnerText,
                                  item["stoptype"].InnerText);
                
                dataView.Rows.Add(item["bustype"].InnerText);//버스종류
                    
                                  item["firsttime"].InnerText,//첫차시간
                                  item["endtime"].InnerText);//막차시간
                    */
                dataView.Rows.Add(item["gpsX"].InnerText,
                                  item["gpsY"].InnerText,
                                  item["bstopId"].InnerText,
                                  item["bstopArsno"].InnerText);
            }

            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
