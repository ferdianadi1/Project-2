﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_App
{
    public partial class MenuTHB : Form
    {
        public MenuTHB()
        {
            InitializeComponent();
        }

        private void btn_refund_Click(object sender, EventArgs e)
        {
            MenuRefund refund = new MenuRefund();
            refund.Show();
            this.Hide();
        }
    }
}
