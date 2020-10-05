namespace BusInfoSystem.Sub
{
    partial class SearchBus
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.BusSearchBt = new MetroFramework.Controls.MetroButton();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.HomeBt = new MetroFramework.Controls.MetroTile();
            this.gpsX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bstopId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bstopArsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(40, 80);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BusSearchBt);
            this.splitContainer1.Panel1.Controls.Add(this.metroTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.dataView);
            this.splitContainer1.Size = new System.Drawing.Size(1196, 548);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 1;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(27, 10);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(990, 50);
            this.metroTextBox1.TabIndex = 0;
            // 
            // BusSearchBt
            // 
            this.BusSearchBt.Location = new System.Drawing.Point(1033, 10);
            this.BusSearchBt.Name = "BusSearchBt";
            this.BusSearchBt.Size = new System.Drawing.Size(150, 50);
            this.BusSearchBt.TabIndex = 1;
            this.BusSearchBt.Text = "검색";
            this.BusSearchBt.Click += new System.EventHandler(this.BusSearchBt_Click);
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gpsX,
            this.gpsY,
            this.bstopId,
            this.bstopArsno});
            this.dataView.Location = new System.Drawing.Point(625, 3);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 27;
            this.dataView.Size = new System.Drawing.Size(558, 468);
            this.dataView.TabIndex = 0;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // HomeBt
            // 
            this.HomeBt.Location = new System.Drawing.Point(1173, 634);
            this.HomeBt.Name = "HomeBt";
            this.HomeBt.Size = new System.Drawing.Size(63, 63);
            this.HomeBt.Style = MetroFramework.MetroColorStyle.White;
            this.HomeBt.TabIndex = 0;
            this.HomeBt.TileImage = global::BusInfoSystem.Properties.Resources.iconfinder___house_home_flat_facilities_3668851__1_;
            this.HomeBt.UseTileImage = true;
            this.HomeBt.Click += new System.EventHandler(this.HomeBt_Click);
            // 
            // gpsX
            // 
            this.gpsX.HeaderText = "GPS X좌표";
            this.gpsX.MinimumWidth = 6;
            this.gpsX.Name = "gpsX";
            // 
            // gpsY
            // 
            this.gpsY.HeaderText = "GPS Y좌표";
            this.gpsY.MinimumWidth = 6;
            this.gpsY.Name = "gpsY";
            // 
            // bstopId
            // 
            this.bstopId.HeaderText = "정류소아이디";
            this.bstopId.MinimumWidth = 6;
            this.bstopId.Name = "bstopId";
            // 
            // bstopArsno
            // 
            this.bstopArsno.HeaderText = "정류소번호";
            this.bstopArsno.MinimumWidth = 6;
            this.bstopArsno.Name = "bstopArsno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(612, 468);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.HomeBt);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SearchBus";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "정류소정보 조회(정류장명을 선택하세요.)";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.SearchBus_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile HomeBt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton BusSearchBt;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsX;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsY;
        private System.Windows.Forms.DataGridViewTextBoxColumn bstopId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bstopArsno;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}