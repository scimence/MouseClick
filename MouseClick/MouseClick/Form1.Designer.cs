namespace MouseClick
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
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonLD = new System.Windows.Forms.Button();
            this.buttonRD = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(29, 72);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(94, 23);
            this.buttonL.TabIndex = 0;
            this.buttonL.Text = "左键点击(&L)";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(145, 72);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(94, 23);
            this.buttonR.TabIndex = 1;
            this.buttonR.Text = "右键点击(&R)";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonLD
            // 
            this.buttonLD.Location = new System.Drawing.Point(29, 111);
            this.buttonLD.Name = "buttonLD";
            this.buttonLD.Size = new System.Drawing.Size(94, 23);
            this.buttonLD.TabIndex = 2;
            this.buttonLD.Text = "左键双击(&K)";
            this.buttonLD.UseVisualStyleBackColor = true;
            this.buttonLD.Click += new System.EventHandler(this.buttonLD_Click);
            // 
            // buttonRD
            // 
            this.buttonRD.Location = new System.Drawing.Point(145, 111);
            this.buttonRD.Name = "buttonRD";
            this.buttonRD.Size = new System.Drawing.Size(94, 23);
            this.buttonRD.TabIndex = 3;
            this.buttonRD.Text = "右键双击(&E)";
            this.buttonRD.UseVisualStyleBackColor = true;
            this.buttonRD.Click += new System.EventHandler(this.buttonRD_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "点击按钮，1.2秒后模拟鼠标点击";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRD);
            this.Controls.Add(this.buttonLD);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonL);
            this.Name = "Form1";
            this.Text = "模拟鼠标点击";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonLD;
        private System.Windows.Forms.Button buttonRD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

