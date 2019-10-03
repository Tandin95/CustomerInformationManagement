using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace CustomerInformationManagementApp
{
    public partial class CustomerInformation : Form
    {
        public CustomerInformation()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void LasName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Month_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string surName = lastName.Text;
            // surName surname = new surName();
            //List<string> message = new List<string>();
            // bool result = surname.Execute(surName, message);  
            string name = firstName.Text;
            string age = ageN.Text;

            string birthyear = year.Text;

            string birthmonth = month.Text;

            string birthdate = date.Text;

            string email = emailAddress.Text;

            label1.Text = "登録されました";

            NameCheck nameCheck = new NameCheck(name, age, birthyear, birthmonth, birthdate, email);

           
        }

        private void CustomerInformation_Load(object sender, EventArgs e)
        {
            date.SelectedIndex = 0;
            month.SelectedIndex = 0;
            year.SelectedIndex = 0;
        }
    }
}
