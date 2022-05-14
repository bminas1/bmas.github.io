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

namespace bmasExecutor2
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
   
        }
        FluxAPI.API API = new FluxAPI.API();
        private void Settings_Click(object sender, EventArgs e)
        {
            Settings g1 = new Settings();
            g1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            API.Inject();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            API.Execute(fastColoredTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = ("");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FluxAPI.API.OnInputRecived += delegate (string input) //OnInputRecived will be called when the DLL sends data to the UI
            {
                this.Invoke(new MethodInvoker(delegate //THIS IS REQUIRED, YOU WILL ERROR WITHOUT THIS
                {

                }));
            };

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                BackColor = cd.Color;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = ("loadstring(game:HttpGet('https://raw.githubusercontent.com/lerkermer/lua-projects/master/SwagModeV002'))()");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game: HttpGet('https://raw.githubusercontent.com/22kristina/dhcrash_gen2/main/crash', true))()";
        }
    }
}
