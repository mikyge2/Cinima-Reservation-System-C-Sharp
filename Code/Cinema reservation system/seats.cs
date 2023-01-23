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
    
    public partial class seats : Form
    {
        public string mvname;
        public seats(string moviename)
        {
            InitializeComponent();
            mvname = moviename;
        }
        public void fillseats()
        {
            string[] takenseats = storedata.whichreserved(mvname);
            for (int i = 0; i < takenseats.Length; i++)
            {

                if (takenseats[i] == "A1")
                {
                    A1.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "A2")
                {
                    A2.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "A3")
                {
                    A3.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "A4")
                {
                    A4.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "A5")
                {
                    A5.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "A6")
                {
                    A6.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "A7")
                {
                    A7.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "A8")
                {
                    A8.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "A9")
                {
                    A9.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "A10")
                {
                    A10.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "A11")
                {
                    A11.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "A12")
                {
                    A12.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "B1")
                {
                    B1.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "B2")
                {
                    B2.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "B3")
                {
                    B3.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "B4")
                {
                    B4.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "B5")
                {
                    B5.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "B6")
                {
                    B6.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "B7")
                {
                    B7.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "B8")
                {
                    B8.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "B9")
                {
                    B9.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "B10")
                {
                    B10.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "B11")
                {
                    B11.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "B12")
                {
                    B12.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "VIP1")
                {
                    VIP1.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "VIP2")
                {
                    VIP2.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "VIP3")
                {
                    VIP3.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "VIP4")
                {
                    VIP4.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "VIP5")
                {
                    VIP5.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "VIP6")
                {
                    VIP6.BackColor = Color.Silver;
                }
                else if (takenseats[i] == "VIP7")
                {
                    VIP7.BackColor = Color.Silver;
                }
            }
        }
        public bool bookseat(string mvname, string noseat)
        {
            mainpage m = new mainpage();
            storedata sd = new storedata();
            login l = new login();
            var showtimes = new Stack<storedata.Showtime>();
            var reservations = new Stack<storedata.Reservation>();
            string datatime = DateTime.Now.ToString(); // it will get the current data and time
            ///////////////////storing movie name and rating///////////////////////////
            ///// Add a movie to the stack

            if (storedata.addreserve(mvname, noseat))
            {
                //////////////////////////////////storing theater and time//////////////////////////////
                ////Add a showtime to the stack
                var showtime = new storedata.Showtime()
                {
                    Theater = "AMC 12",
                    Time = datatime,
                };
                showtimes.Push(showtime);

                // Add a reservation to the stack
                var reservation = new storedata.Reservation()
                {
                    Theater = "AMC 12",
                    Time = datatime,
                    CustomerName = l.usernametextbox.Text,
                    seatnumber = noseat,
                };
                reservations.Push(reservation);

                // Access the top element of the stack
                string name = reservations.Peek().CustomerName;

                //// sending parameter to the ticket page
                string movietitle = mvname;
                string seatno = reservations.Peek().seatnumber;
                string dt = showtimes.Peek().Time;

                cinematicket ct = new cinematicket(movietitle, dt, seatno);
                ct.Show();
                return true;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (A1.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "A1"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }                    
                A1.BackColor=Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (A2.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "A2"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                A2.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (A4.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "A4"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                A4.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (A6.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "A6"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                A6.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (A7.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "A7"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                A7.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (A8.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "A8"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                A8.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (A10.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "A10"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                A10.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (A12.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "A12"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                A12.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (B3.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "B3"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                B3.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (B4.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "B4"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                B4.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (B5.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "B5"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                B5.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (B6.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "B6"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                B6.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (B7.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "B7"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                B7.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (B8.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "B8"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                B8.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (B9.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "B9"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                B9.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (A3.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "A3"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                A3.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void A5_Click(object sender, EventArgs e)
        {
            if (A5.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "A5"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                A5.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void A9_Click(object sender, EventArgs e)
        {
            if (A9.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "A9"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                A9.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void A11_Click(object sender, EventArgs e)
        {
            if (A11.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "A11"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                A11.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void B10_Click(object sender, EventArgs e)
        {
            if (B10.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "B10"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                B10.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void B11_Click(object sender, EventArgs e)
        {
            if (B11.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "B11"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                B11.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void B12_Click(object sender, EventArgs e)
        {
            if (B12.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "B12"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                B12.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (B1.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "B1"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                B1.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (B2.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "B2"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:100 ETB\nproceed to pay at the counter");
                }
                B2.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void VIP1_Click(object sender, EventArgs e)
        {
            if (VIP1.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "VIP1"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:200 ETB\nproceed to pay at the counter");
                }
                VIP1.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void VIP2_Click(object sender, EventArgs e)
        {
            if (VIP2.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "VIP2"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:200 ETB\nproceed to pay at the counter");
                }
                VIP2.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void VIP3_Click(object sender, EventArgs e)
        {
            if (VIP3.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "VIP3"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:200 ETB\nproceed to pay at the counter");
                }
                VIP3.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void VIP4_Click(object sender, EventArgs e)
        {
            if (VIP4.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "VI4"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:200 ETB\nproceed to pay at the counter");
                }
                VIP4.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void VIP5_Click(object sender, EventArgs e)
        {
            if (VIP5.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "VIP5"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:200 ETB\nproceed to pay at the counter");
                }
                VIP5.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void VIP6_Click(object sender, EventArgs e)
        {
            if (VIP6.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "VIP6"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:200 ETB\nproceed to pay at the counter");
                }
                VIP6.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

        private void VIP7_Click(object sender, EventArgs e)
        {
            if (VIP7.BackColor != Color.Silver)
            {
                if (bookseat(mvname, "VIP7"))
                {
                    MessageBox.Show("Seat Reserved Successfully\nPrice:200 ETB\nproceed to pay at the counter");
                }
                VIP7.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Seat Reserveing UnSuccessfull");
            }
        }

  
    }
}


