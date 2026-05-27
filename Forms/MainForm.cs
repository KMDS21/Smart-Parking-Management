using System;
using System.Windows.Forms;

namespace SmartParkingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            new EntryForm().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new ExitForm().ShowDialog();
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome";
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void lblWelcome_Click_1(object sender, EventArgs e)
        {

        }
    }
}