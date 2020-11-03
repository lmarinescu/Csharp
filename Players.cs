﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToes
{
    public partial class Players : Form
    {
        public Players()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TicTacToes.setPlayersNames(p1.Text, p2.Text);
            this.Close();
        }

        private void p2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                button1.PerformClick();
            }
        }
    }
}
