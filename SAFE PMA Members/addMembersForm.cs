﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAFE_PMA_Members
{
    public partial class addMemberForm : Form
    {
        public addMemberForm()
        {
            InitializeComponent();
        }

        private void addSelectMemberButton_Click(object sender, EventArgs e)
        {
            searchMembers form3 = new searchMembers();
            form3.ShowDialog();
        }
    }
}
