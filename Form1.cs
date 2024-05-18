using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void movesidepanel(Button btn)
        {
            panelslide.Top = btn.Top;
            panelslide.Height = btn.Height;
        }


        private void  addUC(UserControl uc)
        {
            panelcenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(uc);
        }

        private void home_Click(object sender, EventArgs e)
        {
            movesidepanel(home);
        }

        private void food_Click(object sender, EventArgs e)
        {
            movesidepanel(food);
            UCFood uCFood = new UCFood();
            addUC(uCFood);
        }

        private void drinks_Click(object sender, EventArgs e)
        {
            movesidepanel(drinks);
            UC_Drinks uC_Drinks = new UC_Drinks();
            addUC(uC_Drinks);
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chat_Click(object sender, EventArgs e)
        {
            movesidepanel(chat);
        }

        private void delivery_Click(object sender, EventArgs e)
        {
            movesidepanel(delivery);
        }

        private void about_Click(object sender, EventArgs e)
        {
            movesidepanel(about);
        }
    }
}
