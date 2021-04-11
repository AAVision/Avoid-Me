using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.Win32;

namespace Avoid
{

    public partial class mainForm : Form
    {
      
        public static class Alliknow
        {
            public static bool _isFirstForm = true;
        }
        public mainForm()
        {
            InitializeComponent();
            
        }
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            mainForm newForm1 = new mainForm();
            mainForm newForm2 = new mainForm();
            newForm1.Show();
            newForm2.Show();
            e.Cancel = true;


           //add the executable file to the startup menu
           // using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
           // {
           //     key.SetValue("My Program", "\"" + Application.ExecutablePath + "\"");
           // }


        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            oathLabel.Text = "Thinking How to make this world more safer" + Environment.NewLine + "HAVE FUN!";

            if ((Alliknow._isFirstForm == true))
                Alliknow._isFirstForm = false;
            else
            {
                //get Maximum Height and Width of the screen
                int maxHeight = Screen.PrimaryScreen.WorkingArea.Height;
                int maxWidth = Screen.PrimaryScreen.WorkingArea.Width;

                //random
                Random ra1 = new Random();

                //set a random position for the generated form
                int _radomPoint1 = ra1.Next(0, maxWidth - this.Width);
                int _radomPoint2 = ra1.Next(0, maxHeight - this.Height);
                this.Location = new Point(_radomPoint1   , _radomPoint2);
               

          
                // set Icon for the Forms
                Icon icon = Icon.ExtractAssociatedIcon("12.ico");
                this.Icon = icon;

            }

            
        }
    }
}
