using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_winForms
{
    public partial class MainGuestForm : Form
    {
        public static MainGuestForm Current;
        public MainGuestForm()
        {
            InitializeComponent();

            Current = this;
        }

        private void allButtonGuest()
        {
            MessageBox.Show("Данная функция не доступна, сперва зарегистрируйтесь!");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            allButtonGuest();
        }

        private void buttonRaiting_Click(object sender, EventArgs e)
        {
            allButtonGuest();
        }

        private void buttonRecommendation_Click(object sender, EventArgs e)
        {
            allButtonGuest();
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            allButtonGuest();
        }

        private void buttonBlog_Click(object sender, EventArgs e)
        {
            allButtonGuest();
        }

        private void buttonReview_Click(object sender, EventArgs e)
        {
            allButtonGuest();
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            allButtonGuest();
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            allButtonGuest();
        }

        private void buttonTopUp_Click(object sender, EventArgs e)
        {
            allButtonGuest();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            allButtonGuest();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            allButtonGuest();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            allButtonGuest();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            RForm rForm = new RForm();
            Current.Hide();
            rForm.ShowDialog();

            Current.Close();
        }
    }
}
