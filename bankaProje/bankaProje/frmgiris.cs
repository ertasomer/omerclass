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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtTC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                giris.PerformClick();
            }
        }

        private void giris_Click(object sender, EventArgs e)
        {
            string sonuc;
            double tc = Convert.ToDouble(txtTC.Text);
            dbislemleri vt = new dbislemleri();
            sonuc = vt.kgiriskontrol(tc);
            if (sonuc != null)
            {
                MessageBox.Show("hoşgeldiniz sayın " + sonuc);
                frmsiraAl frm = new frmsiraAl();
                frm.ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("hatalı tc lütfen geçerli cir Tc giriniz");
            txtTC.Clear();
            txtTC.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmkayit frm = new frmkayit();
            frm.ShowDialog();
            this.Close();
        }
    }
}
