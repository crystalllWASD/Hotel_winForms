using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_winForms
{
    public partial class ChoiceARGForm : Form
    {
        public static ChoiceARGForm Current;
        public ChoiceARGForm()
        {
            InitializeComponent();

            Current = this;
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            AForm aForm = new AForm();
            Current.Hide();
            aForm.ShowDialog();

            Current.Close();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            RForm rForm = new RForm();
            Current.Hide();
            rForm.ShowDialog();

            Current.Close();
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            MainGuestForm mgForm = new MainGuestForm();
            Current.Hide();
            mgForm.ShowDialog();
        }
    }
}
