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
    public partial class AForm : Form
    {
        public static AForm Current;
        public AForm()
        {
            InitializeComponent();

            Current = this;
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            if (cbHotelOwner.Checked)
            {
                MainHotelForm mhForm = new MainHotelForm();
                Current.Hide();
                mhForm.ShowDialog();
            }
            else
            {
                MainUserForm muForm = new MainUserForm();
                Current.Hide();
                muForm.ShowDialog();
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            textBoxPass.PasswordChar = '*';
        }
    }
}
