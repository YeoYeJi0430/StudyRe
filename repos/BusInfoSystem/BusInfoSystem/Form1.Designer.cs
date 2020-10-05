namespace BusInfoSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.BusTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(762, 177);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(383, 348);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "노선정보 조회";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::BusInfoSystem.Properties.Resources.iconfinder_vehicles_12_809732__1_;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // BusTile
            // 
            this.BusTile.Location = new System.Drawing.Point(123, 177);
            this.BusTile.Name = "BusTile";
            this.BusTile.Size = new System.Drawing.Size(380, 348);
            this.BusTile.Style = MetroFramework.MetroColorStyle.Green;
            this.BusTile.TabIndex = 0;
            this.BusTile.Text = "정류소정보 조회";
            this.BusTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BusTile.TileImage = global::BusInfoSystem.Properties.Resources.iconfinder_BUS_STOP_transportation_signaling_buildings_security_5452487;
            this.BusTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BusTile.UseTileImage = true;
            this.BusTile.Click += new System.EventHandler(this.BusTile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.BusTile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "버스정보시스템";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile BusTile;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

