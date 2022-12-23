using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bankaProje
{
    public partial class frmsiraAl : Form
    {
        public frmsiraAl()
        {
            InitializeComponent();
        }
        int i = 0;
        int x = 500;
        private void button1_Click(object sender, EventArgs e)
        {
            
            i++;
           
                MessageBox.Show("Sıranız= "+i);
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x++;

            MessageBox.Show("Sıranız= " + x);
        }
    }
}
