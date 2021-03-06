﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaNavarino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //MenuStrip: Orizoume fonto transparent 
            menuStrip1.BackColor = Color.Transparent;
            


            //apagoreysi ston xristi na allazei to megethos ths formas
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //vazoume to menustrip να μπορει να εμφανιζει tooltip
            menuStrip1.ShowItemToolTips = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // About: mono click kai emfanizei to periexomeno
            MessageBox.Show("Το project  αυτό εκπονήθηκε από τους μεταπτυχιακούς φοιτητές Αρη-Ενρι Βαγγέλη και Δημήτρη Κοσμά");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*//otan pame na klisoume thn efarmogh patwntas x,tha vgei ena mnm pou tha mas rwtaei ti theloume na kanoume
            //an pathsoume nai tote tha klisei alliws oxi tha meinei opws einai
            DialogResult dialogResult1 = MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.Yes)
            {
                e.Cancel = false;
                
                
            }
            else if (dialogResult1 == DialogResult.No)
            {

                e.Cancel = true;
            }*/
        }

        private void aboutToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

            //και στην συνεχεια βαζουμε τι να εμφανιζει 
            aboutToolStripMenuItem.ToolTipText = "Σχετικα με εμάς";
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {

            
        }

        private void exitToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

            //και στην συνεχεια βαζουμε τι να εμφανιζει 
            exitToolStripMenuItem.ToolTipText = "Βγείτε απο την εφαρμογή";
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailForm mailform = new MailForm();
            mailform.Show(this);
            this.Hide();
        }

        private void contactUsToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            //και στην συνεχεια βαζουμε τι να εμφανιζει
            contactUsToolStripMenuItem.ToolTipText = "Στείλτε μας email";
        }
    }
}
