﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginC {
    public partial class FrmPrincipal : Form {
        public FrmPrincipal() {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e) {

        }

        private void btnTerminar_Click(object sender, EventArgs e) {
            we login = new we();
            this.Hide();
            login.Show();
        }
    }
}