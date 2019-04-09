namespace FanYiDemo
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFanyi = new System.Windows.Forms.Button();
            this.lblSourceText = new System.Windows.Forms.Label();
            this.txtSourceText = new System.Windows.Forms.TextBox();
            this.lblLanguageType = new System.Windows.Forms.Label();
            this.chbEnglish = new System.Windows.Forms.CheckBox();
            this.chbFrench = new System.Windows.Forms.CheckBox();
            this.chbGerman = new System.Windows.Forms.CheckBox();
            this.chbRussian = new System.Windows.Forms.CheckBox();
            this.chbKorean = new System.Windows.Forms.CheckBox();
            this.chbJapan = new System.Windows.Forms.CheckBox();
            this.chbSpanish = new System.Windows.Forms.CheckBox();
            this.txtTranText = new System.Windows.Forms.TextBox();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFanyi
            // 
            this.btnFanyi.Location = new System.Drawing.Point(480, 82);
            this.btnFanyi.Name = "btnFanyi";
            this.btnFanyi.Size = new System.Drawing.Size(75, 23);
            this.btnFanyi.TabIndex = 0;
            this.btnFanyi.Text = "翻译";
            this.btnFanyi.UseVisualStyleBackColor = true;
            this.btnFanyi.Click += new System.EventHandler(this.btnFanyi_Click);
            // 
            // lblSourceText
            // 
            this.lblSourceText.AutoSize = true;
            this.lblSourceText.Location = new System.Drawing.Point(29, 13);
            this.lblSourceText.Name = "lblSourceText";
            this.lblSourceText.Size = new System.Drawing.Size(29, 12);
            this.lblSourceText.TabIndex = 1;
            this.lblSourceText.Text = "原文";
            // 
            // txtSourceText
            // 
            this.txtSourceText.Location = new System.Drawing.Point(65, 3);
            this.txtSourceText.Name = "txtSourceText";
            this.txtSourceText.Size = new System.Drawing.Size(490, 21);
            this.txtSourceText.TabIndex = 2;
            // 
            // lblLanguageType
            // 
            this.lblLanguageType.AutoSize = true;
            this.lblLanguageType.Location = new System.Drawing.Point(31, 42);
            this.lblLanguageType.Name = "lblLanguageType";
            this.lblLanguageType.Size = new System.Drawing.Size(29, 12);
            this.lblLanguageType.TabIndex = 3;
            this.lblLanguageType.Text = "语种";
            // 
            // chbEnglish
            // 
            this.chbEnglish.AutoSize = true;
            this.chbEnglish.Location = new System.Drawing.Point(67, 42);
            this.chbEnglish.Name = "chbEnglish";
            this.chbEnglish.Size = new System.Drawing.Size(48, 16);
            this.chbEnglish.TabIndex = 4;
            this.chbEnglish.Text = "英语";
            this.chbEnglish.UseVisualStyleBackColor = true;
            // 
            // chbFrench
            // 
            this.chbFrench.AutoSize = true;
            this.chbFrench.Location = new System.Drawing.Point(134, 42);
            this.chbFrench.Name = "chbFrench";
            this.chbFrench.Size = new System.Drawing.Size(48, 16);
            this.chbFrench.TabIndex = 4;
            this.chbFrench.Text = "法语";
            this.chbFrench.UseVisualStyleBackColor = true;
            // 
            // chbGerman
            // 
            this.chbGerman.AutoSize = true;
            this.chbGerman.Location = new System.Drawing.Point(197, 41);
            this.chbGerman.Name = "chbGerman";
            this.chbGerman.Size = new System.Drawing.Size(48, 16);
            this.chbGerman.TabIndex = 4;
            this.chbGerman.Text = "德语";
            this.chbGerman.UseVisualStyleBackColor = true;
            // 
            // chbRussian
            // 
            this.chbRussian.AutoSize = true;
            this.chbRussian.Location = new System.Drawing.Point(262, 42);
            this.chbRussian.Name = "chbRussian";
            this.chbRussian.Size = new System.Drawing.Size(48, 16);
            this.chbRussian.TabIndex = 4;
            this.chbRussian.Text = "俄语";
            this.chbRussian.UseVisualStyleBackColor = true;
            // 
            // chbKorean
            // 
            this.chbKorean.AutoSize = true;
            this.chbKorean.Location = new System.Drawing.Point(316, 41);
            this.chbKorean.Name = "chbKorean";
            this.chbKorean.Size = new System.Drawing.Size(48, 16);
            this.chbKorean.TabIndex = 4;
            this.chbKorean.Text = "韩语";
            this.chbKorean.UseVisualStyleBackColor = true;
            // 
            // chbJapan
            // 
            this.chbJapan.AutoSize = true;
            this.chbJapan.Location = new System.Drawing.Point(370, 41);
            this.chbJapan.Name = "chbJapan";
            this.chbJapan.Size = new System.Drawing.Size(48, 16);
            this.chbJapan.TabIndex = 4;
            this.chbJapan.Text = "日语";
            this.chbJapan.UseVisualStyleBackColor = true;
            // 
            // chbSpanish
            // 
            this.chbSpanish.AutoSize = true;
            this.chbSpanish.Location = new System.Drawing.Point(433, 41);
            this.chbSpanish.Name = "chbSpanish";
            this.chbSpanish.Size = new System.Drawing.Size(72, 16);
            this.chbSpanish.TabIndex = 4;
            this.chbSpanish.Text = "西班牙语";
            this.chbSpanish.UseVisualStyleBackColor = true;
            // 
            // txtTranText
            // 
            this.txtTranText.Location = new System.Drawing.Point(67, 127);
            this.txtTranText.Multiline = true;
            this.txtTranText.Name = "txtTranText";
            this.txtTranText.Size = new System.Drawing.Size(488, 231);
            this.txtTranText.TabIndex = 5;
            // 
            // lblTranslation
            // 
            this.lblTranslation.AutoSize = true;
            this.lblTranslation.Location = new System.Drawing.Point(29, 107);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(29, 12);
            this.lblTranslation.TabIndex = 6;
            this.lblTranslation.Text = "译文";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 383);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.txtTranText);
            this.Controls.Add(this.chbSpanish);
            this.Controls.Add(this.chbJapan);
            this.Controls.Add(this.chbKorean);
            this.Controls.Add(this.chbRussian);
            this.Controls.Add(this.chbGerman);
            this.Controls.Add(this.chbFrench);
            this.Controls.Add(this.chbEnglish);
            this.Controls.Add(this.lblLanguageType);
            this.Controls.Add(this.txtSourceText);
            this.Controls.Add(this.lblSourceText);
            this.Controls.Add(this.btnFanyi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFanyi;
        private System.Windows.Forms.Label lblSourceText;
        private System.Windows.Forms.TextBox txtSourceText;
        private System.Windows.Forms.Label lblLanguageType;
        private System.Windows.Forms.CheckBox chbEnglish;
        private System.Windows.Forms.CheckBox chbFrench;
        private System.Windows.Forms.CheckBox chbGerman;
        private System.Windows.Forms.CheckBox chbRussian;
        private System.Windows.Forms.CheckBox chbKorean;
        private System.Windows.Forms.CheckBox chbJapan;
        private System.Windows.Forms.CheckBox chbSpanish;
        private System.Windows.Forms.TextBox txtTranText;
        private System.Windows.Forms.Label lblTranslation;
    }
}

