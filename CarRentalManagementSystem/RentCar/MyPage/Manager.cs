﻿using RentCar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mypage
{
    public partial class Manager_Mypage : Form
    {
        public Manager_Mypage()
        {
            InitializeComponent();
        }

        private void BtnUserManagerment_Click(object sender, EventArgs e)
        {
            CustomerManagement showform = new CustomerManagement();
            showform.ShowDialog();
        }
    }
}
