﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonalTracking
{
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the name field");
            }
            else
            {
                DEPARTMENT department = new DEPARTMENT();
                department.departmentName = txtDepartment.Text;
                BLL.DepartmentBLL.AddDepartment(department);
            }
            
        }
    }
}
