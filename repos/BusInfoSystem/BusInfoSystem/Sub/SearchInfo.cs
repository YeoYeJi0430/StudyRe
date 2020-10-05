using MetroFramework.Forms;
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
    public partial class SearchInfo : MetroForm
    {
        public SearchInfo()
        {
            InitializeComponent();
        }

        private void SearchInfo_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            this.Close();
        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            WebClient webc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument docc = new XmlDocument();

            StringBuilder strr = new StringBuilder();

            strr.Append("http://61.43.246.153/openapi-data/service/busanBIMS2/busInfo");
            strr.Append("?ServiceKey=qexPs8LeXjOa6LAjpXww4Hj1sUYBqYhvT%2F9PQnZs40ZVjgSkaK7kVy%2FdKo2Z7lB5EUBzZ2XB7mGnMiQcxtSgDg%3D%3D");

            strr.Append($"&lineno={TxtSearch.Text}");//버스번호
            strr.Append("&pageNo=1");
            strr.Append("&numOfRows = 200");

            string xml = webc.DownloadString(strr.ToString());

            docc.LoadXml(xml);

            XmlElement root = docc.DocumentElement;
            XmlNodeList items = docc.GetElementsByTagName("item");

            dataGridView1.Rows.Clear();

            
            foreach (XmlNode item in items) //items는 리스트
            {
                dataGridView1.Rows.Add(item["buslinenum"]?.InnerText,
                                       item["firsttime"]?.InnerText,
                                       item["endtime"]?.InnerText,
                                       item["headway"]?.InnerText
                                       );
            }
            
            
            
           // dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
