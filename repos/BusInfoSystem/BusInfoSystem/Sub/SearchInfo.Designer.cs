namespace BusInfoSystem.Sub
{
    partial class SearchInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lineno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firsttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(23, 63);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.TxtSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1234, 562);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.TabIndex = 2;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(3, 6);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(1053, 48);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(1062, 6);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(160, 45);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineno,
            this.firsttime,
            this.endtime,
            this.headway});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1234, 502);
            this.dataGridView1.TabIndex = 0;
            // 
            // lineno
            // 
            this.lineno.HeaderText = "번호";
            this.lineno.MinimumWidth = 6;
            this.lineno.Name = "lineno";
            this.lineno.Width = 200;
            // 
            // firsttime
            // 
            this.firsttime.HeaderText = "첫차시간";
            this.firsttime.MinimumWidth = 6;
            this.firsttime.Name = "firsttime";
            this.firsttime.Width = 200;
            // 
            // endtime
            // 
            this.endtime.HeaderText = "막차시간";
            this.endtime.MinimumWidth = 6;
            this.endtime.Name = "endtime";
            this.endtime.Width = 200;
            // 
            // headway
            // 
            this.headway.HeaderText = "배차간격";
            this.headway.MinimumWidth = 6;
            this.headway.Name = "headway";
            this.headway.Width = 200;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(1154, 625);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(103, 83);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.TileImage = global::BusInfoSystem.Properties.Resources.iconfinder___house_home_flat_facilities_3668851__1_;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // SearchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.metroTile1);
            this.Name = "SearchInfo";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "노선정보 조회(버스번호를 입력하세요.)";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.SearchInfo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private MetroFramework.Controls.MetroTextBox TxtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineno;
        private System.Windows.Forms.DataGridViewTextBoxColumn firsttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn headway;
    }
}