namespace 找茬助手
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReflush = new System.Windows.Forms.Button();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonTop = new System.Windows.Forms.Button();
            this.panelStart = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStart.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonStart.Location = new System.Drawing.Point(0, 456);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 61);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.TabStop = false;
            this.buttonStart.Text = "开始/暂停(&B)";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReflush
            // 
            this.buttonReflush.BackColor = System.Drawing.Color.Transparent;
            this.buttonReflush.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReflush.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonReflush.Location = new System.Drawing.Point(186, 456);
            this.buttonReflush.Name = "buttonReflush";
            this.buttonReflush.Size = new System.Drawing.Size(90, 61);
            this.buttonReflush.TabIndex = 3;
            this.buttonReflush.TabStop = false;
            this.buttonReflush.Text = "刷   新 (右键)";
            this.buttonReflush.UseVisualStyleBackColor = false;
            this.buttonReflush.Click += new System.EventHandler(this.buttonReflush_Click);
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.Image = global::找茬助手.Properties.Resources.left;
            this.pictureBoxRight.Location = new System.Drawing.Point(509, 0);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(500, 450);
            this.pictureBoxRight.TabIndex = 0;
            this.pictureBoxRight.TabStop = false;
            this.pictureBoxRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRight_MouseUp);
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Image = global::找茬助手.Properties.Resources.left;
            this.pictureBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(500, 450);
            this.pictureBoxLeft.TabIndex = 0;
            this.pictureBoxLeft.TabStop = false;
            this.pictureBoxLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLeft_MouseUp);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAbout.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAbout.Location = new System.Drawing.Point(282, 456);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(92, 61);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.TabStop = false;
            this.buttonAbout.Text = "关于(&A)";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonTop
            // 
            this.buttonTop.BackColor = System.Drawing.Color.Transparent;
            this.buttonTop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTop.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonTop.Location = new System.Drawing.Point(92, 456);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(91, 61);
            this.buttonTop.TabIndex = 2;
            this.buttonTop.TabStop = false;
            this.buttonTop.Text = "置于前端(&F)";
            this.buttonTop.UseVisualStyleBackColor = false;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // panelStart
            // 
            this.panelStart.BackColor = System.Drawing.Color.Transparent;
            this.panelStart.Location = new System.Drawing.Point(814, 456);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(112, 94);
            this.panelStart.TabIndex = 5;
            this.panelStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelStart_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::找茬助手.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1010, 551);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonTop);
            this.Controls.Add(this.buttonReflush);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxRight);
            this.Controls.Add(this.pictureBoxLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "找茬助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonReflush;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Panel panelStart;
    }
}

