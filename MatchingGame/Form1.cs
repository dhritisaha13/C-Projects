using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matching_Game
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (DataOK())
            {
                this.Hide();
                MatchingGame mg = new MatchingGame(FirstName.Text);
                mg.ShowDialog();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Salutation.SelectedIndex = 0;
            FirstName.Text = null;
            first_name_msg.Text = null;
            LastName.Text = null;
            last_name_msg.Text = null;
            Email.Text = null;
            email_msg.Text = null;
            first_name_msg.ForeColor = Color.Black;
            last_name_msg.ForeColor = Color.Black;
            email_msg.ForeColor = Color.Black;
        }

        public bool DataOK()
        {
            bool rv = true;

            if (FirstName.Text.Length == 0 || FirstName.Text is null)
            {
                first_name_msg.Text = "First name is required.";
                first_name_msg.ForeColor = Color.Red;
                rv = false;
            }
            if (LastName.Text.Length == 0 || LastName.Text is null)
            {
                last_name_msg.Text = "Last name is required.";
                last_name_msg.ForeColor = Color.Red;
                rv = false;

            }
            if (Email.Text.Length == 0 || Email.Text is null)
            {
                email_msg.Text = "Email is required.";
                email_msg.ForeColor = Color.Red;
                rv = false;
            }
            return rv;
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            Salutation.SelectedIndex = 0;
            FirstName.Text = null;
            first_name_msg.Text = null;
            LastName.Text = null;
            last_name_msg.Text = null;
            Email.Text = null;
            email_msg.Text = null;
            first_name_msg.ForeColor = Color.Black;
            last_name_msg.ForeColor = Color.Black;
            email_msg.ForeColor = Color.Black;
        }
    }
}
