using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class FrmLogin : Form
    {
        string username = "admin";
        string password = "1234";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == "" && txtUsername.Text == "")
            {
                MessageBox.Show("Forma je prazna!", "Problem", MessageBoxButtons.OK,
MessageBoxIcon.Error);
            }
                else if (txtUsername.Text == "")
                {
                    MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                }
            
            else if (txtPassword.Text == password && txtUsername.Text == username)
            {
                FrmStudents frmStudents = new FrmStudents();
                Hide();
                frmStudents.ShowDialog();
                Close();

            }
            else if(txtPassword.Text != password && txtUsername.Text != username) 
            {
                MessageBox.Show("Korisničko ime i/ili lozinka nisu točni!", "Pokušajte ponovno", MessageBoxButtons.OK,
    MessageBoxIcon.Error);
            }



        }
    }
}
