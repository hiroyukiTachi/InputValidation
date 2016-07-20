using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyValidation;

namespace TestMyValidation
{
    /// <summary>
    /// 入力検証フォームクラス
    /// </summary>
    public partial class frmValidation : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmValidation()
        {
            InitializeComponent();
        }

        private void txtNumber_Leave(object sender, EventArgs e)
        {
            string result = MyValidation.Validator.exec(txtNumber.Text, ValidateTyle.Number);
            MessageBox.Show(result);
            
        }

        private void txtAlphabet_Leave(object sender, EventArgs e)
        {
            string result = MyValidation.Validator.exec(txtAlphabet.Text, ValidateTyle.Alphabet);
            MessageBox.Show(result);
        }

        private void txtPostNumber_Leave(object sender, EventArgs e)
        {
            string result = MyValidation.Validator.exec(txtPostNumber.Text, ValidateTyle.PostNumber);
            MessageBox.Show(result);
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            string result = MyValidation.Validator.exec(txtPhoneNumber.Text, ValidateTyle.PhoneNumber);
            MessageBox.Show(result);
        }

        private void txtMailAddress_Leave(object sender, EventArgs e)
        {
            string result = MyValidation.Validator.exec(txtMailAddress.Text, ValidateTyle.MailAddress);
            MessageBox.Show(result);
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            string result = MyValidation.Validator.exec(txtUrl.Text, ValidateTyle.Url);
            MessageBox.Show(result);
        }

    }
}
