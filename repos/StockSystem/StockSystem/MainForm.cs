using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using StockSystem.Sub;

namespace StockSystem
{
    public partial class MainForm : MetroForm //Form
    {
        public MainForm()
        {
            InitializeComponent();

            //화면 전환시 위치 옮겨도 그 위치에 오픈
            //메인폼에 넣어서 첫위치를 고정시키기
            //참조: https://mapgmer.tistory.com/3
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2 +
            Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

        }

        private void MtlSearchItem_Click(object sender, EventArgs e)
        {
            //창 없애기
            this.Visible = false;

            //서치폼 오픈 , 화면전환
            SearchForm search = new SearchForm();   //오픈시 필요
            search.Location = this.Location;        //나의 위치를 서치화면에 보내줌
            search.ShowDialog();                    //오픈시 필요

            //main폼 닫기
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            //서치폼 오픈 , 화면전환
            GalmetgilForm search = new GalmetgilForm();   //오픈시 필요
            search.Location = this.Location;        //나의 위치를 서치화면에 보내줌
            search.ShowDialog();                    //오픈시 필요

            //main폼 닫기
            this.Close();
        }
    }
}
