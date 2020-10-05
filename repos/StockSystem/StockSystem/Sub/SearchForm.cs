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

namespace StockSystem.Sub
{
    public partial class SearchForm : MetroForm//Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //서치폼에 패널2에있는 위쪽글자 폰트변경, 
            DgvSearchItems.Font = new Font(@"NanumGothic", 10, FontStyle.Regular);
        }

        private void MtlBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            //메인폼 오픈
            MainForm main = new MainForm();
            main.Location = this.Location;
            main.ShowDialog();

            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)    //검색버튼
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();//class
            str.Append("http://api.seibro.or.kr/openapi/service/StockSvc/getStkIsinByNmN1");//Open API 기본 URL
            //https://www.data.go.kr/tcs/dss/selectApiDataDetailView.do?publicDataPk=15001145


            str.Append("?serviceKey=qexPs8LeXjOa6LAjpXww4Hj1sUYBqYhvT%2F9PQnZs40ZVjgSkaK7kVy%2FdKo2Z7lB5EUBzZ2XB7mGnMiQcxtSgDg%3D%3D");//인증키
            //https://www.data.go.kr/iim/api/selectAPIAcountView.do

            str.Append($"&secnNm={TxtSearchItem.Text}");//0번째 위치,검색어
            str.Append("&numOfRows=200");//읽어올데이터수
            str.Append("&pageNo=1");//페이지번호
            //URL 제일처음파라미터는 '?' 그 다음 부터는 '&'

            str.Append("&martTpcd=11");//주식시장 종류 11 유가증권


            //결과돌아오는건xml
            string xml = wc.DownloadString(str.ToString());
            //결과나온걸xml보내기
            doc.LoadXml(xml);

            //document를root에 넣음
            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item"); // xml태그에서 <item>에 있는값들을 items에 넣음

            DgvSearchItems.Rows.Clear();

            try
            {
                foreach (XmlNode item in items) //items는 리스트
                {
                    DgvSearchItems.Rows.Add(item["isin"].InnerText,                                          //표준코드 데이터넣음(isin),
                                            item["issuDt"] == null ? string.Empty : item["issuDt"].InnerText,//주식발행일자
                                                                                                             //에러 확인 : item["issuDt"].InnerText
                                            item["korSecnNm"].InnerText,                                     //한글 종목명
                                            item["secnKacdNm"].InnerText,                                    //보통주/우선주
                                            item["shotnIsin"].InnerText                                      //단축코드
                                            );
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러발생! : {ex.Message}","에러",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            DgvSearchItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //들어오는데이터 열 자동 추가
        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)   //enter = 13
            {
                BtnSearch_Click(sender, new EventArgs());   //enter == click  (UX : User eXperience)
            }
        }
    }
}
