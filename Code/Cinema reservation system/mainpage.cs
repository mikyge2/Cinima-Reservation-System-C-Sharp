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
    
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent; // Making Label Transparent
            label1.Parent = pictureBox1;
            label2.BackColor = Color.Transparent; // Making Label Transparent
            label2.Parent = pictureBox1;
            storedata.loadmovies();
        }
        private void avatar_Click(object sender, EventArgs e) // Listner function when avatar is selcted
        {
            string movie = "Avatar"; // Assignment
            seats s = new seats(movie); //Declaring new Seats Window
            s.fillseats();
            s.Show(); // Show seats windows;
        }
            

        private void blackadam_Click(object sender, EventArgs e) // Listner function when Blackadam is selcted
        {
            string movie = "Black Adam"; // Assignment
            seats s = new seats(movie); //Declaring new Seats Window
            s.fillseats();
            s.Show(); // Show seats windows
        }

        private void lostcity_Click(object sender, EventArgs e) // Listner function when Lost City is selcted
        {
            string movie = "Lost City"; // Assignment
            seats s = new seats(movie); //Declaring new Seats Window
            s.fillseats();
            s.Show(); // Show seats windows
        }

        private void beast_Click(object sender, EventArgs e) // Listner function when Beast is selcted
        {
            string movie = "Beast"; // Assignment
            seats s = new seats(movie); //Declaring new Seats Window
            s.fillseats();
            s.Show(); // Show seats windows
        }

        private void jocker_Click(object sender, EventArgs e) // Listner function when Jocker is selcted 
        {
            string movie = "Jocker"; // Assignment
            seats s = new seats(movie); //Declaring new Seats Window
            s.fillseats();
            s.Show(); // Show seats windows
        }

        private void Wood_Click(object sender, EventArgs e) // Listner function when Wood is selcted
        {
            string movie = "Wood"; // Assignment
            seats s = new seats(movie); //Declaring new Seats Window
            s.fillseats();
            s.Show(); // Show seats windows
        }

        private void Matrix_Click(object sender, EventArgs e) // Listner function when matrix is selcted
        {
            string movie = "Matrix: The Ressurection"; // Assignment
            seats s = new seats(movie); //Declaring new Seats Window
            s.fillseats();
            s.Show(); // Show seats windows
        }

        private void logoutbutton_Click(object sender, EventArgs e) // Listner function when logout is clicked
        {
            Close();
        }
    }
   
}
