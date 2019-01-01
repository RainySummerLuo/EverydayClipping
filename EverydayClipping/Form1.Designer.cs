using System;
using System.Windows.Forms;

namespace EverydayClipping {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("方正屏显雅宋_GBK", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel1.Location = new System.Drawing.Point(61, 34);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(483, 156);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.Fuchsia;
            this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel2.Location = new System.Drawing.Point(5, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(59, 68);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.Text = "“";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ForeColor = System.Drawing.Color.Fuchsia;
            this.linkLabel3.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel3.Location = new System.Drawing.Point(550, 161);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(59, 68);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.Text = "”";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.Font = new System.Drawing.Font("方正屏显雅宋_GBK", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel4.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel4.Location = new System.Drawing.Point(12, 205);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(597, 61);
            this.linkLabel4.TabIndex = 3;
            this.linkLabel4.Text = "—— 刘慈欣，《三体》";
            this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.ForeColor = System.Drawing.Color.Fuchsia;
            this.linkLabel5.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel5.Location = new System.Drawing.Point(18, 207);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(53, 51);
            this.linkLabel5.TabIndex = 4;
            this.linkLabel5.Text = "▶";
            this.linkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            this.linkLabel5.LocationChanged += new System.EventHandler(this.linkLabel5_LocationChanged);
            this.linkLabel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabel5_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(621, 274);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "EverydayClipping";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
    }
}

