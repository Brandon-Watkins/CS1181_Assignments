// frm.Main.cs
// CS 1181
// Brandon Watkins
// 14 January 2019
// Robert Howe
// Description: Application that gathers the user's name, and says hello to the user.
// WOW: 
// I've coded the Say Hello button to "randomly" select and change the background color, 
// and the backgrounds of each button/textbox. 
// I also gave it a Goodbye button as an alternate way to exit the application. 
// To make this application even more obnoxious, I attempted to color code the 
// Message Box, by creating my own, but I couldn't figure out how to add a label to it.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class frmMain : Form
    {

        // helping to not get the same first "random" color every time you restart the program.
        private Random random = new Random(); 


        public frmMain()
        {
            InitializeComponent();
        }

        
        private void btnSayHello_Click(object sender, EventArgs e)
        {
            // Creating a new random color variable for each of my controls, which is updated
            // each time you click on the Say Hello button.
            Color randomColor0 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            Color randomColor1 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            Color randomColor2 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            Color randomColor3 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            BackColor = randomColor0;
            txtName.BackColor = randomColor1;
            btnSayBye.BackColor = randomColor2;
            btnSayHello.BackColor = randomColor3;
            MessageBox.Show("Hello " + txtName.Text + "!");
            
        }

        private void btnSayBye_Click(object sender, EventArgs e)
        {
            // Closes the application when you click on the Say Goodbye button.
            MessageBox.Show("Goodbye " + txtName.Text + "!");
            Close();
        }
    }
}
