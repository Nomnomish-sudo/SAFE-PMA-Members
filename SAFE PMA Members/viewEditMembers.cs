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
    public partial class viewEditMembers : Form
    {
        List<Member> members = new List<Member>();
        public viewEditMembers()
        {
            InitializeComponent();

            UpdateListing();
        }

        private void UpdateListing()
        {
            membersListbox.DataSource = members;
            membersListbox.DisplayMember = "DisplayInfo";
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            members = db.MemberList(LastNameTextbox.Text);

            UpdateListing();
        }
    }
}
