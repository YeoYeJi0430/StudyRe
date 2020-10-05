namespace FileBrowser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TvFolder = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ChTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChMD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpen.Location = new System.Drawing.Point(713, 12);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 26);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path :";
            // 
            // TxtPath
            // 
            this.TxtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPath.Location = new System.Drawing.Point(63, 12);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.ReadOnly = true;
            this.TxtPath.Size = new System.Drawing.Size(644, 25);
            this.TxtPath.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TvFolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 350);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // TvFolder
            // 
            this.TvFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvFolder.Location = new System.Drawing.Point(0, 0);
            this.TvFolder.Name = "TvFolder";
            this.TvFolder.Size = new System.Drawing.Size(266, 350);
            this.TvFolder.TabIndex = 0;
            this.TvFolder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TvFolder_BeforeExpand);
            this.TvFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvFolder_AfterSelect);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChTitle,
            this.ChSize,
            this.ChType,
            this.ChMD});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 350);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ChTitle
            // 
            this.ChTitle.Text = "이름";
            this.ChTitle.Width = 200;
            // 
            // ChSize
            // 
            this.ChSize.Text = "크기";
            this.ChSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ChSize.Width = 100;
            // 
            // ChType
            // 
            this.ChType.Text = "종류";
            this.ChType.Width = 100;
            // 
            // ChMD
            // 
            this.ChMD.Text = "수정일자";
            this.ChMD.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FileBrowser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TvFolder;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ChTitle;
        private System.Windows.Forms.ColumnHeader ChSize;
        private System.Windows.Forms.ColumnHeader ChType;
        private System.Windows.Forms.ColumnHeader ChMD;
    }
}

