using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockSystem.Sub
{
    public partial class DownloadForm : MetroForm
    {
        public string ParentUrl { get; set; }

        WebClient client;
        public DownloadForm()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void DownloadForm_Load(object sender, EventArgs e)
        {
            //label1.Text = Panel
            //다운로드폼 초기화
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string fileName = ParentUrl.Substring(ParentUrl.IndexOf('=') + 1);
            pictureBox1.Load(Environment.CurrentDirectory + $@"\{fileName}");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate() //<-대리자
            {
                progressBar1.Value = e.ProgressPercentage;

                if(e.BytesReceived == e.TotalBytesToReceive)//다운받은양이 전체양과 같으면.
                {
                    Client_DownloadFileCompleted(sender, null);//이벤트발생
                }
            }));
        }

        private void DownloadForm_Shown(object sender, EventArgs e)
        {
            //화면뜨고나서 이벤트
            Thread thread = new Thread(new ThreadStart(StartDownload));//ThreadStart(스레드처리할것 넣기)
            thread.Start();
        }

        private void StartDownload()
        {
            Uri uri = new Uri(ParentUrl);
            string fileName = ParentUrl.Substring(ParentUrl.IndexOf('=') + 1);
            client.DownloadFileAsync(uri, Environment.CurrentDirectory + $@"\{fileName}");//비동기로 값 받기(uri값넘겨주기,\는 원래 명령어(?) 그래서 \\ 두 개 써야함, 하지만 @붙이면 한번만 \ 해도 됨

            //파일명 자르기
            //"https://www.busan.go.kr/PageDownload.do?savename="galmaetgil_course_4.jpg : ""만 필요해서 자르기

        }
    }
}
