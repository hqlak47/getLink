
namespace 提取链接
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.btnGetCopy = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.Tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnM = new System.Windows.Forms.Button();
            this.ls = new System.Windows.Forms.Label();
            this.btnBD = new System.Windows.Forms.Button();
            this.btn250 = new System.Windows.Forms.Button();
            this.Btn25 = new System.Windows.Forms.Button();
            this.BtnGetTxt = new System.Windows.Forms.Button();
            this.RtbTxtList = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tb1 = new System.Windows.Forms.TextBox();
            this.BtnCc = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rtb
            // 
            this.rtb.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb.Location = new System.Drawing.Point(12, 12);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(708, 393);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            // 
            // rtb1
            // 
            this.rtb1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb1.Location = new System.Drawing.Point(740, 12);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(708, 674);
            this.rtb1.TabIndex = 1;
            this.rtb1.Text = "";
            // 
            // btnGetCopy
            // 
            this.btnGetCopy.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetCopy.Location = new System.Drawing.Point(740, 725);
            this.btnGetCopy.Name = "btnGetCopy";
            this.btnGetCopy.Size = new System.Drawing.Size(249, 44);
            this.btnGetCopy.TabIndex = 2;
            this.btnGetCopy.Text = "提取并复制";
            this.btnGetCopy.UseVisualStyleBackColor = true;
            this.btnGetCopy.Click += new System.EventHandler(this.btnGetCopy_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopy.Location = new System.Drawing.Point(1150, 725);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(131, 44);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn.Location = new System.Drawing.Point(1017, 725);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(105, 44);
            this.btn.TabIndex = 4;
            this.btn.Text = "提取";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClean.Location = new System.Drawing.Point(1309, 725);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(131, 44);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "清空";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Tb
            // 
            this.Tb.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb.Location = new System.Drawing.Point(277, 734);
            this.Tb.Name = "Tb";
            this.Tb.Size = new System.Drawing.Size(443, 35);
            this.Tb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 737);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "链接都有的文字：";
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnM.Location = new System.Drawing.Point(436, 786);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(284, 44);
            this.btnM.TabIndex = 8;
            this.btnM.Text = "提取磁力链接并复制";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // ls
            // 
            this.ls.AutoSize = true;
            this.ls.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ls.Location = new System.Drawing.Point(23, 796);
            this.ls.Name = "ls";
            this.ls.Size = new System.Drawing.Size(22, 24);
            this.ls.TabIndex = 9;
            this.ls.Text = "0";
            // 
            // btnBD
            // 
            this.btnBD.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBD.Location = new System.Drawing.Point(740, 786);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(249, 44);
            this.btnBD.TabIndex = 10;
            this.btnBD.Text = "提取百度网盘链接";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btn250
            // 
            this.btn250.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn250.Location = new System.Drawing.Point(1017, 786);
            this.btn250.Name = "btn250";
            this.btn250.Size = new System.Drawing.Size(105, 44);
            this.btn250.TabIndex = 11;
            this.btn250.Text = "250更新";
            this.btn250.UseVisualStyleBackColor = true;
            this.btn250.Click += new System.EventHandler(this.btn250_Click);
            // 
            // Btn25
            // 
            this.Btn25.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn25.Location = new System.Drawing.Point(1150, 786);
            this.Btn25.Name = "Btn25";
            this.Btn25.Size = new System.Drawing.Size(131, 44);
            this.Btn25.TabIndex = 12;
            this.Btn25.Text = "去除250";
            this.Btn25.UseVisualStyleBackColor = true;
            this.Btn25.Click += new System.EventHandler(this.Btn25_Click);
            // 
            // BtnGetTxt
            // 
            this.BtnGetTxt.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGetTxt.Location = new System.Drawing.Point(1309, 786);
            this.BtnGetTxt.Name = "BtnGetTxt";
            this.BtnGetTxt.Size = new System.Drawing.Size(131, 44);
            this.BtnGetTxt.TabIndex = 13;
            this.BtnGetTxt.Text = "获取TXT";
            this.BtnGetTxt.UseVisualStyleBackColor = true;
            this.BtnGetTxt.Click += new System.EventHandler(this.BtnGetTxt_Click);
            // 
            // RtbTxtList
            // 
            this.RtbTxtList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbTxtList.Location = new System.Drawing.Point(12, 411);
            this.RtbTxtList.Name = "RtbTxtList";
            this.RtbTxtList.Size = new System.Drawing.Size(708, 275);
            this.RtbTxtList.TabIndex = 14;
            this.RtbTxtList.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(113, 786);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "获取已存在";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tb1
            // 
            this.Tb1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb1.Location = new System.Drawing.Point(277, 693);
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(443, 35);
            this.Tb1.TabIndex = 16;
            // 
            // BtnCc
            // 
            this.BtnCc.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCc.Location = new System.Drawing.Point(277, 786);
            this.BtnCc.Name = "BtnCc";
            this.BtnCc.Size = new System.Drawing.Size(127, 44);
            this.BtnCc.TabIndex = 17;
            this.BtnCc.Text = "查重";
            this.BtnCc.UseVisualStyleBackColor = true;
            this.BtnCc.Click += new System.EventHandler(this.BtnCc_Click);
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "文件模式",
            "文本模式"});
            this.cb.Location = new System.Drawing.Point(33, 702);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(121, 25);
            this.cb.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 841);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.BtnCc);
            this.Controls.Add(this.Tb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RtbTxtList);
            this.Controls.Add(this.BtnGetTxt);
            this.Controls.Add(this.Btn25);
            this.Controls.Add(this.btn250);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.ls);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGetCopy);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.rtb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提取链接";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.Button btnGetCopy;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox Tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Label ls;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Button btn250;
        private System.Windows.Forms.Button Btn25;
        private System.Windows.Forms.Button BtnGetTxt;
        private System.Windows.Forms.RichTextBox RtbTxtList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tb1;
        private System.Windows.Forms.Button BtnCc;
        private System.Windows.Forms.ComboBox cb;
    }
}

