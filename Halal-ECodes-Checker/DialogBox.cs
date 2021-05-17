﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Halal_ECodes_Checker
{
    public partial class DialogBox : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        //Add this Before Initilize Components Method
        bool dragging;
        Point offset;
        public DialogBox()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MsgBox_Load(object sender, EventArgs e)
        {
            int Wdth = Title.Size.Width;
            panel2.Size = new Size(Wdth, panel2.Size.Height);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MsgBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.ParentForm != null)
                this.ParentForm.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            //Add this Under Control_MouseDown Event
            dragging = true;
            offset = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            //Add this Under Control_MouseUp Event
            dragging = false;
        }

        private void message_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}
