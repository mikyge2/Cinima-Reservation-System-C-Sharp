using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_reservation_system
{
    public partial class login : Form
    {
        public string [] usr = { "user", "user2" }; // String array to store usernames
        public string [] pass = { "user", "user2" }; // String array to store passwords
        public string [] hintq = { "Whats your name?", "How old are you" }; // String array to store hint question
        public string [] hinta = { "Abebe", "20" }; // String array to store hint answer
        public login()
        {
            InitializeComponent();
            // Username Label
            usernamelabel.BackColor = Color.Transparent; // Making Label Transparent
            usernamelabel.Parent = pictureBox1;
            // Password Label
            passwordlabel.BackColor = Color.Transparent; // Making Label Transparent
            passwordlabel.Parent = pictureBox1;
            // Forgot Password Label
            forgotpasslabel.BackColor = Color.Transparent; // Making Label Transparent
            forgotpasslabel.Parent = pictureBox1; 
            // Clearing Error Providers
            usernameerror.Clear(); //Clearing Username Error Provider
            passworderror.Clear(); //Clearing New Password Error Provider
        }

        private void closebutton_Click(object sender, EventArgs e) // Listner function when close is clicked
        {
            Close(); // Closing Window
        }

        public bool ismatch()  // Function to search for a match
        {
            int i; // Declaring
            bool found=false; // Declaring
            for(i=0; i< usr.Length; i++) // Iterating through array
            {
                if (usernametextbox.Text == usr[i]) // user exist
                {
                    found = true; // Flagging
                    break;
                } 
            }
            if (found && pass[i]==passwordtextbox.Text) // password and username match
            {
                return true;
            }
            return false; // No Match
        } 
        private void loginbutton_Click(object sender, EventArgs e) // Listner function when Login is clicked
        {
            usernameerror.Clear(); //Clearing Username Error Provider
            passworderror.Clear(); //Clearing New Password Error Provider
            string username = usernametextbox.Text; // Assigning Username
            string password = passwordtextbox.Text; // Assigning Password
            if (string.IsNullOrEmpty(usernametextbox.Text) || usernametextbox.Text.Length < 4 || usernametextbox.Text.Length > 20) // Selection for invalid username 
            {
                usernameerror.Clear(); //Clearing Username Error Provider
                usernameerror.SetError(usernametextbox, "Enter a valid username"); //Setting Username Error Provider
            }
            if (string.IsNullOrEmpty(passwordtextbox.Text) || passwordtextbox.Text.Length < 4 || usernametextbox.Text.Length > 20) // Selection for invalid new password
            {
                passworderror.Clear(); //Clearing New Password Error Provider
                passworderror.SetError(passwordtextbox, "Enter a valid Password"); //Setting New Password Error Provider
            }
            if (!string.IsNullOrEmpty(usernametextbox.Text) && usernametextbox.Text.Length >= 4 && usernametextbox.Text.Length <= 20 &&
                !string.IsNullOrEmpty(passwordtextbox.Text) && passwordtextbox.Text.Length >= 4 && usernametextbox.Text.Length <= 20) // Selection for valid username and new password
            {
                if (ismatch()) // Selection for checking match of credentials
                {
                    mainpage mn = new mainpage(); //Declaring new Main Page Window
                    mn.Show(); //Show main page Window
                }
                else
                {
                    MessageBox.Show("Username or Password Incorrect"); // Pop-up Message
                }
            }
        }

        private void forgotpasslabel_Click(object sender, EventArgs e) // Listner function when forgot password is clicked
        {
            forgotpass f = new forgotpass(); //Declaring new Forgot Password Window
            f.Show(); //Show forgot password Window
            Hide(); //Hide Currently Active Window
        }
    }
}
