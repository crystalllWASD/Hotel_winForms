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
    public partial class RForm : Form
    {
        public static RForm Current;
        public RForm()
        {
            InitializeComponent();

            Current = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                HotelRForm hrForm = new HotelRForm();
                Current.Hide();
                hrForm.ShowDialog();

                Current.Close();
            }
            else
            {
                MainUserForm muForm = new MainUserForm();
                Current.Hide();
                muForm.ShowDialog();

                Current.Close();
            }
        }
    }
}
