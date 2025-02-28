﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Integrador_Construção_do_Sistema
{
    public partial class CadastroUsuario : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBoarderBtnt;
        private Form currentChildForm;
        //Constructor
        public CadastroUsuario()
        {
            InitializeComponent();
            leftBoarderBtnt = new Panel();
            leftBoarderBtnt.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBoarderBtnt);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        //Structs
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);

            //para caso eu for usa futuramente ou adicinar um botao.
            /*public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);*/


        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left board button
                leftBoarderBtnt.BackColor = color;
                leftBoarderBtnt.Location = new Point(0, currentBtn.Location.Y);
                leftBoarderBtnt.Visible = true;
                leftBoarderBtnt.BringToFront();

                //Icon Corrent Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (currentChildForm != null)
            {
                //Open only form
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ChildForm);
            panelDesktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            lblTitleChildForm.Text = ChildForm.Text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
           /* OpenChildForm();*/
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color2);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
        }
    }
}
