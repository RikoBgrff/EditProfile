using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPG Files(' *.jpg ')|*.*|PNG Files(*.png)| *.png||";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(open.FileName))
                {
                    guna2CirclePictureBox1.Load(open.FileName);
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(' *.* ')|*.*|Text Files(*.txt)| *.txt||";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(open.FileName))
                {
                    guna2HtmlLabel3.Text = reader.ReadToEnd();
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName))
                {
                    writer.Write(guna2HtmlLabel3.Text);
                }
            }
            MessageBox.Show("Description Saved");
        }
    }
    }

