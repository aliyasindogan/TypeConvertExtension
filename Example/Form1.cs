using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            #region Convert

            DateTime date1 = Convert.ToDateTime(txtDate.Text);
            int number1 = Convert.ToInt32(txtNumber.Text);

            #endregion Convert

            #region With Extension

            DateTime date = txtDate.ToDateTime();
            int number = txtNumber.ToInt();

            #endregion With Extension
        }
    }
}