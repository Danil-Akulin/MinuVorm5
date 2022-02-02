using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinuVorm
{
    public partial class login : Form
    {
        public PictureBox img = new PictureBox();

        public TextBox box = new TextBox();

        public TextBox box2 = new TextBox();

        public TextBox box3 = new TextBox();

        public TextBox box4 = new TextBox();

        public login()
        {
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Text = "Login";
            img.Size = new Size(900, 508);
            img.Image = Image.FromFile(@"..\..\img\koik.jpg");





            box.Location = new Point(300, 200);
            box.Text = "Login";
            Font myfont = new Font("Times New Roman", 25.0f);    
            box.Font = myfont;                                   
            box.ReadOnly = true;                               
            box.Height = 250;
            box.Width = 80;
            box.BackColor = Color.FromArgb(255, 207, 215, 226);
            box.BorderStyle = 0;                            
            this.Controls.Add(box);


            box2.Location = new Point(300, 250);
            box2.Text = "Password";
            Font myfont2 = new Font("Times New Roman", 25.0f);
            box2.Font = myfont2;
            box2.ReadOnly = true;
            box2.Height = 250;
            box2.Width = 140;
            box2.BackColor = Color.FromArgb(255, 136, 145, 174);
            box2.BorderStyle = 0;
            this.Controls.Add(box2);
            this.Controls.Add(img);


            box3.Location = new Point(450, 250);
            box3.Text = "Your password";
            Font myfont3 = new Font("Times New Roman", 20.0f);
            box3.Font = myfont3;
            box3.ReadOnly = false;
            box3.Height = 250;
            box3.Width = 160;
            box3.BackColor = Color.FromArgb(255, 193, 198, 213);
            box3.BorderStyle = 0;
            box3.Click += Box3_Click;


            box4.Location = new Point(450, 200);
            box4.Text = "Your login";
            Font myfont4 = new Font("Times New Roman", 20.0f);
            box4.Font = myfont4;
            box4.ReadOnly = false;
            box4.Height = 250;
            box4.Width = 160;
            box4.BackColor = Color.FromArgb(255, 207, 215, 226);
            box4.BorderStyle = 0;
            box4.Click += Box4_Click;
            






            this.Controls.Add(box3);
            this.Controls.Add(box4);
            this.Controls.Add(img);

        }

        private void Box4_Click(object sender, EventArgs e)
        {
            box4.Clear();
        }

        private void Box3_Click(object sender, EventArgs e)
        {
            box3.Clear();
        }
    }

}
