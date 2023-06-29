using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_winForms
{
    public partial class MainUserForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-R13SFHK\\SQLEXPRESS01; Initial Catalog=GreatPlace; User=DESKTOP-R13SFHK\\crystalll; Integrated Security=SSPI";
        public MainUserForm()
        {
            InitializeComponent();
            FillComboBoxCountry();
        }
        private void FillComboBoxCountry()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Country", con);
                    SqlDataReader sdr = cmd.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Load(sdr);

                    comboBoxCountry.DisplayMember = "Countries";
                    comboBoxCountry.ValueMember = "Id";
                    comboBoxCountry.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countryId = (int)comboBoxCountry.SelectedValue;

            FillComboBoxCity(countryId);
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cityId = (int)comboBoxCity.SelectedValue;

            FillComboBoxStreet(cityId);
        }

        private void comboBoxStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int streetId = (int)comboBoxStreet.SelectedValue;

            FillComboBoxHome(streetId);
        }

        private void FillComboBoxCity(int countryId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM City WHERE CountriesId=@CountryId", con);
                    cmd.Parameters.AddWithValue("@CountryId", countryId);

                    SqlDataReader sdr = cmd.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Load(sdr);

                    comboBoxCity.DisplayMember = "Cities";
                    comboBoxCity.ValueMember = "Id";
                    comboBoxCity.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void FillComboBoxStreet(int cityId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Street WHERE CitiesId=@CityId", con);
                    cmd.Parameters.AddWithValue("@CityId", cityId);

                    SqlDataReader sdr = cmd.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Load(sdr);

                    comboBoxStreet.DisplayMember = "Streets";
                    comboBoxStreet.ValueMember = "Id";
                    comboBoxStreet.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void FillComboBoxHome(int streetId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Homes FROM Home WHERE StreetsId=@StreetId", con);
                    cmd.Parameters.AddWithValue("@StreetId", streetId);

                    SqlDataReader sdr = cmd.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Load(sdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }
        //private void Connect()
        //{
        //    table = new DataTable();
        //    con = new SqlConnection(cs);
        //    con.Open();
        //    cmd = new SqlCommand($"SELECT * FROM Hotel", con);
        //    sdr = cmd.ExecuteReader();
        //}
    }
}
