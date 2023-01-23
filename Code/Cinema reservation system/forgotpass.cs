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
    public partial class forgotpass : Form
    {
        public forgotpass()
        {
            InitializeComponent();
            // Username Label
            usernamelabel.BackColor = Color.Transparent; // Making Label Transparent
            usernamelabel.Parent = pictureBox1;
            // New Password Label
            newpasswordlabel.BackColor = Color.Transparent; // Making Label Transparent
            newpasswordlabel.Parent = pictureBox1;
            // Hint Answer Label
            hintlable.BackColor = Color.Transparent; // Making Label Transparent
            hintlable.Parent = pictureBox1;
            // Hint Question Label
            questionlabel.BackColor = Color.Transparent; // Making Label Transparent
            questionlabel.Parent = pictureBox1;
            // Hint Answer Label
            answerlabel.BackColor = Color.Transparent; // Making Label Transparent
            answerlabel.Parent = pictureBox1;
        }

        private void forgotpass_Load(object sender, EventArgs e) // Function for Initial loading of Forgot Password Window
        {
            resetviewbutton.Visible = true;
            resetbutton.Visible = false;
            hintlable.Visible = false;
            questionlabel.Visible = false;
            answerlabel.Visible = false;
            hinttextbox.Visible = false;
            newpasswordlabel.Visible = false;
            newpasswordtextbox.Visible = false;
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            login l = new login(); //Declaring new Login Window
            l.Show(); //Show Login Window
            this.Close(); //Hide Currently Active Window
        }

        private void resetviewbutton_Click(object sender, EventArgs e)
        {
            login l = new login(); //Declaring new Login Window
            bool found = false; // Declaring
            for (int i = 0; i < l.usr.Length; i++) // Iterating through array
            {
                if (usernametextbox.Text == l.usr[i]) // user exist
                {
                    questionlabel.Text = l.hintq[i];
                    found = true;
                    break;
                }
            }
            if (found) // Selection when user is not existing 
            {
                resetviewbutton.Visible = false;
                resetbutton.Visible = true;
                hintlable.Visible = true;
                questionlabel.Visible = true;
                answerlabel.Visible = true;
                hinttextbox.Visible = true;
                newpasswordlabel.Visible = true;
                newpasswordtextbox.Visible = true;
            }
            else
            {
                MessageBox.Show("User not Found. Try Again"); // Pop Up message
            }  
        }

        private void resetbutton_Click_1(object sender, EventArgs e)
        {
            usernameerror.Clear(); //Clearing Username Error Provider
            passworderror.Clear(); //Clearing New Password Error Provider
            hinterror.Clear(); //Clearing Hint Answer Error Provider
            if (string.IsNullOrEmpty(usernametextbox.Text) || usernametextbox.Text.Length < 4 || usernametextbox.Text.Length > 20) // Selection for invalid username 
            {
                usernameerror.Clear(); //Clearing Username Error Provider
                usernameerror.SetError(usernametextbox, "Enter a valid username"); //Setting Username Error Provider
            }
            if (string.IsNullOrEmpty(newpasswordtextbox.Text) || newpasswordtextbox.Text.Length < 4 || usernametextbox.Text.Length > 20) // Selection for invalid new password
            {
                passworderror.Clear(); //Clearing New Password Error Provider
                passworderror.SetError(newpasswordtextbox, "Enter a valid Password"); //Setting New Password Error Provider
            }
            if (string.IsNullOrEmpty(hinttextbox.Text)) // Selection for empty hint answer
            {
                hinterror.Clear(); //Clearing Hint Answer Error Provider
                hinterror.SetError(hinttextbox, "Enter a valid Hint Answer"); //Setting Hint Answer Error Provider
            }
            if (!string.IsNullOrEmpty(usernametextbox.Text) && !string.IsNullOrEmpty(newpasswordtextbox.Text) && !string.IsNullOrEmpty(hinttextbox.Text) && newpasswordtextbox.Text.Length >= 4 && usernametextbox.Text.Length >= 4)
            { // Selection for all fields field accordingly
                if (newpasswordtextbox.Text.Length < 20) // Selection when user is existing and password isn't long
                {
                    int i = 0;
                    login l = new login(); //Declaring new Login Window
                    for (i = 0; i < l.usr.Length; i++) // Iterating through array
                    {
                        if (usernametextbox.Text == l.usr[i]) // go to user
                        {
                            if (hinttextbox.Text == l.hinta[i]) // Selection of Correct Hint Answer
                            {
                                l.pass[i] = newpasswordtextbox.Text;
                                MessageBox.Show("Password Reset Successful"); // Pop-up Message
                                l.Show(); //Show Login Window
                                this.Close(); //Hide Currently Active Window
                                
                            }
                            else // Selection of Wrong Hint Answer
                            {
                                MessageBox.Show("Hint Answer Incorrect. Try again"); // Pop-up Message
                                break;
                            }
                        }
                    }
                }
                else // Selection when password is long
                {
                    passworderror.Clear(); //Clearing New Password Error Provider
                    passworderror.SetError(newpasswordtextbox, "Password must be less than 20 characters"); //Setting New Password Error Provider
                }
            }
        }
    }
}
