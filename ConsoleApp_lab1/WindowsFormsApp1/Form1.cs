using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //step 1 - Get no of textbox from user
                int NoOfTextbox = int.Parse(textBox1.Text);

                //step 2 - validate if it is between 1 and 10
                if(NoOfTextbox >= 1 && NoOfTextbox <= 10)
                {

                    //step 3 - create a text box and display on screen
                    while(NoOfTextbox != 0 )
                    {
                        TextBox t = new TextBox();
                        t.Name = "textbox" + NoOfTextbox;
                        Point p = new Point(50, 60 * NoOfTextbox);
                        Size s = new Size(100, 30);
                        t.Size = s;
                        t.Location = p;
                        this.Controls.Add(t);

                        NoOfTextbox--;
                    }
                }
                else
                {
                    MessageBox.Show("Enter number betwwen 1 to 10 ");
                    textBox1.Text="";
                    textBox1.Focus();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
