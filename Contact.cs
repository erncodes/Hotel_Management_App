﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_App
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(455, 190);
        }

        private void label62_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel43_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_contact_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
