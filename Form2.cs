using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmasExecutor2
{
    public partial class Settings : Form
    {
        public static Settings instance;
        public Settings()
        {
            InitializeComponent();
            instance = this;
        }
        FluxAPI.API API = new FluxAPI.API();

        private void button1_Click(object sender, EventArgs e)
        {
            API.SetFPSCap(120);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            API.SetFPSCap(144);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            API.SetFPSCap(160);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            API.SetFPSCap(180);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            API.SetFPSCap(200);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            API.SetFPSCap();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            API.SetFPSCap(60);
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            }
        }
    }

