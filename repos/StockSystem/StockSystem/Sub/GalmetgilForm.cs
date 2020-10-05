using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
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
    public partial class GalmetgilForm : MetroForm//Form
    {
        public GalmetgilForm()
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
           
            StringBuilder str = new StringBuilder();//class
            str.Append("http://apis.data.go.kr/6260000/BusanGalmaetGilService/getGalmaetGilInfo");//요청주소
            str.Append("?ServiceKey=qexPs8LeXjOa6LAjpXww4Hj1sUYBqYhvT%2F9PQnZs40ZVjgSkaK7kVy%2FdKo2Z7lB5EUBzZ2XB7mGnMiQcxtSgDg%3D%3D");//일반인증키
            str.Append("&pageNo=1");
            str.Append("&numOfRows=10");
            str.Append("&resultType=json");

            //결과돌아오는건json
            string json = wc.DownloadString(str.ToString());
            //결과나온걸json보내기
            //json의 최상클래스=jobject
            JObject obj = JObject.Parse(json);
            //json에서 item부분 가지고옴
            JArray items = JArray.Parse(obj.SelectToken("getGalmaetGilInfo.item").ToString());

            DgvSearchItems.Rows.Clear();
            /*
            try
            {
                
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러발생! : {ex.Message}","에러",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

            foreach (var item in items)
            {
                //kosNm, kosType, kosTxt, img, txt1, title, txt2
                DgvSearchItems.Rows.Add(
                    $"{item.SelectToken("kosNm")}",
                    $"{item.SelectToken("kosType")}",
                    $"{item.SelectToken("kosTxt")}",
                    $"{item.SelectToken("img")}",
                    $"{item.SelectToken("txt1")}",
                    $"{item.SelectToken("title")}",
                    $"{item.SelectToken("txt2")}"
                    );
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

        private void DgvSearchItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //데이터 더블클릭시 이미지 다운
            var selvalue = DgvSearchItems.Rows[e.RowIndex].Cells[3/*e.ColumnIndex*/].Value.ToString();//더블클릭한위치를 넘겨줌,
            //MessageBox.Show(selvalue);//어느 위치를 클릭했는지 메시지박스 띄어줌
            DownloadForm form = new DownloadForm();
            form.ParentUrl = selvalue;
            form.ShowDialog();
        }
    }
}
