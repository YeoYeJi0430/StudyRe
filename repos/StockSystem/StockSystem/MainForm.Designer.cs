namespace StockSystem
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
            this.MtlStockAnals = new MetroFramework.Controls.MetroTile();
            this.MtlInvestSiumuls = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.MtlSearchItem = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MtlStockAnals
            // 
            this.MtlStockAnals.Location = new System.Drawing.Point(381, 91);
            this.MtlStockAnals.Name = "MtlStockAnals";
            this.MtlStockAnals.Size = new System.Drawing.Size(220, 150);
            this.MtlStockAnals.Style = MetroFramework.MetroColorStyle.Orange;
            this.MtlStockAnals.TabIndex = 0;
            this.MtlStockAnals.Text = "주식정보분석";
            this.MtlStockAnals.TileImage = global::StockSystem.Properties.Resources.analysis2;
            this.MtlStockAnals.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlStockAnals.UseTileImage = true;
            this.MtlStockAnals.Click += new System.EventHandler(this.MtlSearchItem_Click);
            // 
            // MtlInvestSiumuls
            // 
            this.MtlInvestSiumuls.Location = new System.Drawing.Point(381, 261);
            this.MtlInvestSiumuls.Name = "MtlInvestSiumuls";
            this.MtlInvestSiumuls.Size = new System.Drawing.Size(300, 150);
            this.MtlInvestSiumuls.Style = MetroFramework.MetroColorStyle.Lime;
            this.MtlInvestSiumuls.TabIndex = 0;
            this.MtlInvestSiumuls.Text = "투자시뮬레이션";
            this.MtlInvestSiumuls.TileImage = global::StockSystem.Properties.Resources.simulator2;
            this.MtlInvestSiumuls.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlInvestSiumuls.UseTileImage = true;
            this.MtlInvestSiumuls.Click += new System.EventHandler(this.MtlSearchItem_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(654, 91);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(300, 150);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "갈맷길정보검색";
            this.metroTile1.TileImage = global::StockSystem.Properties.Resources.seagull2;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // MtlSearchItem
            // 
            this.MtlSearchItem.Location = new System.Drawing.Point(64, 91);
            this.MtlSearchItem.Name = "MtlSearchItem";
            this.MtlSearchItem.Size = new System.Drawing.Size(300, 150);
            this.MtlSearchItem.TabIndex = 0;
            this.MtlSearchItem.Text = "주식정보검색";
            this.MtlSearchItem.TileImage = global::StockSystem.Properties.Resources.marketing2;
            this.MtlSearchItem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlSearchItem.UseTileImage = true;
            this.MtlSearchItem.Click += new System.EventHandler(this.MtlSearchItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MtlStockAnals);
            this.Controls.Add(this.MtlInvestSiumuls);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.MtlSearchItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "주식분석시스템";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtlSearchItem;
        private MetroFramework.Controls.MetroTile MtlStockAnals;
        private MetroFramework.Controls.MetroTile MtlInvestSiumuls;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

