namespace QuantumCode.CAPTCHAReader.Sample
{
    partial class frmThresholdingAlgorithm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbSRC = new System.Windows.Forms.PictureBox();
            this.pbDEST = new System.Windows.Forms.PictureBox();
            this.btnNormalGray = new System.Windows.Forms.Button();
            this.btnReselectImg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnThreshodingGray = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDEST)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbSRC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 401);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThreshodingGray);
            this.panel2.Controls.Add(this.btnReselectImg);
            this.panel2.Controls.Add(this.btnNormalGray);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(293, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 401);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbDEST);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(416, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 401);
            this.panel3.TabIndex = 1;
            // 
            // pbSRC
            // 
            this.pbSRC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSRC.Image = global::QuantumCode.CAPTCHAReader.Sample.Properties.Resources.dataMatrix_raw;
            this.pbSRC.Location = new System.Drawing.Point(0, 0);
            this.pbSRC.Name = "pbSRC";
            this.pbSRC.Size = new System.Drawing.Size(293, 401);
            this.pbSRC.TabIndex = 0;
            this.pbSRC.TabStop = false;
            // 
            // pbDEST
            // 
            this.pbDEST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDEST.Location = new System.Drawing.Point(0, 0);
            this.pbDEST.Name = "pbDEST";
            this.pbDEST.Size = new System.Drawing.Size(299, 401);
            this.pbDEST.TabIndex = 1;
            this.pbDEST.TabStop = false;
            // 
            // btnNormalGray
            // 
            this.btnNormalGray.Location = new System.Drawing.Point(15, 76);
            this.btnNormalGray.Name = "btnNormalGray";
            this.btnNormalGray.Size = new System.Drawing.Size(89, 34);
            this.btnNormalGray.TabIndex = 0;
            this.btnNormalGray.Text = "灰度化>>";
            this.btnNormalGray.UseVisualStyleBackColor = true;
            this.btnNormalGray.Click += new System.EventHandler(this.btnNormalGray_Click);
            // 
            // btnReselectImg
            // 
            this.btnReselectImg.Location = new System.Drawing.Point(15, 25);
            this.btnReselectImg.Name = "btnReselectImg";
            this.btnReselectImg.Size = new System.Drawing.Size(89, 33);
            this.btnReselectImg.TabIndex = 1;
            this.btnReselectImg.Text = "选择图片...";
            this.btnReselectImg.UseVisualStyleBackColor = true;
            this.btnReselectImg.Click += new System.EventHandler(this.btnReselectImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg|BMP|*.bmp";
            this.openFileDialog1.Title = "选择一个图片文件";
            // 
            // btnThreshodingGray
            // 
            this.btnThreshodingGray.Location = new System.Drawing.Point(15, 132);
            this.btnThreshodingGray.Name = "btnThreshodingGray";
            this.btnThreshodingGray.Size = new System.Drawing.Size(89, 34);
            this.btnThreshodingGray.TabIndex = 2;
            this.btnThreshodingGray.Text = "二值灰度化>>";
            this.btnThreshodingGray.UseVisualStyleBackColor = true;
            this.btnThreshodingGray.Click += new System.EventHandler(this.btnThreshodingGray_Click);
            // 
            // frmThresholdingAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmThresholdingAlgorithm";
            this.Text = "灰度化测试";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDEST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSRC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbDEST;
        private System.Windows.Forms.Button btnNormalGray;
        private System.Windows.Forms.Button btnReselectImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnThreshodingGray;
    }
}

