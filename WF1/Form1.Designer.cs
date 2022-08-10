
namespace WF1
{
    partial class DB
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Data_List = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refresh = new System.Windows.Forms.Label();
            this.Data_Read_Btn = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Create_Table_Btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Drop_Table_Btn = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.엑셀로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStatus = new System.Windows.Forms.Label();
            this.iNFOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(559, 242);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(417, 286);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(559, 534);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(417, 45);
            this.trackBar1.TabIndex = 5;
            // 
            // Data_List
            // 
            this.Data_List.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Data_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.name,
            this.password});
            this.Data_List.HideSelection = false;
            this.Data_List.HoverSelection = true;
            this.Data_List.Location = new System.Drawing.Point(47, 190);
            this.Data_List.Name = "Data_List";
            this.Data_List.Size = new System.Drawing.Size(506, 352);
            this.Data_List.TabIndex = 6;
            this.Data_List.UseCompatibleStateImageBehavior = false;
            this.Data_List.View = System.Windows.Forms.View.Details;
            // 
            // num
            // 
            this.num.Width = 100;
            // 
            // name
            // 
            this.name.Width = 100;
            // 
            // password
            // 
            this.password.Width = 100;
            // 
            // refresh
            // 
            this.refresh.AutoSize = true;
            this.refresh.Location = new System.Drawing.Point(74, 33);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(53, 12);
            this.refresh.TabIndex = 7;
            this.refresh.Text = "리프레시";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Data_Read_Btn
            // 
            this.Data_Read_Btn.AutoSize = true;
            this.Data_Read_Btn.Location = new System.Drawing.Point(151, 33);
            this.Data_Read_Btn.Name = "Data_Read_Btn";
            this.Data_Read_Btn.Size = new System.Drawing.Size(69, 12);
            this.Data_Read_Btn.TabIndex = 10;
            this.Data_Read_Btn.Text = "테이블 읽기";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNFOToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.iNFOToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNFOToolStripMenuItem
            // 
            this.iNFOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_Table_Btn,
            this.Drop_Table_Btn});
            this.iNFOToolStripMenuItem.Name = "iNFOToolStripMenuItem";
            this.iNFOToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.iNFOToolStripMenuItem.Text = "테이블 관리";
            // 
            // Create_Table_Btn
            // 
            this.Create_Table_Btn.Name = "Create_Table_Btn";
            this.Create_Table_Btn.Size = new System.Drawing.Size(180, 22);
            this.Create_Table_Btn.Text = "테이블 생성";
            this.Create_Table_Btn.Click += new System.EventHandler(this.Create_Table_Btn_Click);
            // 
            // Drop_Table_Btn
            // 
            this.Drop_Table_Btn.Name = "Drop_Table_Btn";
            this.Drop_Table_Btn.Size = new System.Drawing.Size(180, 22);
            this.Drop_Table_Btn.Text = "테이블 드랍";
            this.Drop_Table_Btn.Click += new System.EventHandler(this.Drop_Table_Btn_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.엑셀로저장ToolStripMenuItem});
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.저장ToolStripMenuItem.Text = "저장";
            // 
            // 엑셀로저장ToolStripMenuItem
            // 
            this.엑셀로저장ToolStripMenuItem.Name = "엑셀로저장ToolStripMenuItem";
            this.엑셀로저장ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.엑셀로저장ToolStripMenuItem.Text = "엑셀로 저장";
            this.엑셀로저장ToolStripMenuItem.Click += new System.EventHandler(this.엑셀로저장ToolStripMenuItem_Click);
            // 
            // mStatus
            // 
            this.mStatus.AutoSize = true;
            this.mStatus.Location = new System.Drawing.Point(80, 165);
            this.mStatus.Name = "mStatus";
            this.mStatus.Size = new System.Drawing.Size(29, 12);
            this.mStatus.TabIndex = 15;
            this.mStatus.Text = "상태";
            // 
            // iNFOToolStripMenuItem1
            // 
            this.iNFOToolStripMenuItem1.Name = "iNFOToolStripMenuItem1";
            this.iNFOToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.iNFOToolStripMenuItem1.Text = "INFO";
            // 
            // DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 600);
            this.Controls.Add(this.mStatus);
            this.Controls.Add(this.Data_Read_Btn);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.Data_List);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DB";
            this.Text = "데이터베이스 관리 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar trackBar1;
        public System.Windows.Forms.ListView Data_List;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.Label refresh;
        private System.Windows.Forms.Label Data_Read_Btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 엑셀로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFOToolStripMenuItem;
        private System.Windows.Forms.Label mStatus;
        private System.Windows.Forms.ToolStripMenuItem Create_Table_Btn;
        private System.Windows.Forms.ToolStripMenuItem Drop_Table_Btn;
        private System.Windows.Forms.ToolStripMenuItem iNFOToolStripMenuItem1;
    }
}

