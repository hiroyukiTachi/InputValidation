namespace TestMyValidation
{
    partial class frmValidation
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAlphabet = new System.Windows.Forms.TextBox();
            this.txtPostNumber = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtMailAddress = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(234, 39);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(459, 31);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.Leave += new System.EventHandler(this.txtNumber_Leave);
            // 
            // txtAlphabet
            // 
            this.txtAlphabet.Location = new System.Drawing.Point(234, 96);
            this.txtAlphabet.Name = "txtAlphabet";
            this.txtAlphabet.Size = new System.Drawing.Size(459, 31);
            this.txtAlphabet.TabIndex = 2;
            this.txtAlphabet.Leave += new System.EventHandler(this.txtAlphabet_Leave);
            // 
            // txtPostNumber
            // 
            this.txtPostNumber.Location = new System.Drawing.Point(234, 155);
            this.txtPostNumber.Name = "txtPostNumber";
            this.txtPostNumber.Size = new System.Drawing.Size(459, 31);
            this.txtPostNumber.TabIndex = 4;
            this.txtPostNumber.Leave += new System.EventHandler(this.txtPostNumber_Leave);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(234, 211);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(459, 31);
            this.txtPhoneNumber.TabIndex = 5;
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.Location = new System.Drawing.Point(234, 269);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.Size = new System.Drawing.Size(459, 31);
            this.txtMailAddress.TabIndex = 6;
            this.txtMailAddress.Leave += new System.EventHandler(this.txtMailAddress_Leave);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(234, 327);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(459, 31);
            this.txtUrl.TabIndex = 7;
            this.txtUrl.Leave += new System.EventHandler(this.txtUrl_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "半角数字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "半角英字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "郵便番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "電話番号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "メールアドレス";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "URL";
            // 
            // frmValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 396);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtMailAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtPostNumber);
            this.Controls.Add(this.txtAlphabet);
            this.Controls.Add(this.txtNumber);
            this.Name = "frmValidation";
            this.Text = "入力検証";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAlphabet;
        private System.Windows.Forms.TextBox txtPostNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtMailAddress;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

