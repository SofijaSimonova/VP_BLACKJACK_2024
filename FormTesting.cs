﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class FormTesting : Form
    {
        public FormTesting()
        {
            InitializeComponent();
        }

        private void FromTesting_Load(object sender, EventArgs e)
        {

        }

        private void btn_deck_Click(object sender, EventArgs e)
        {
            DeckTest deckTest = new DeckTest();
            //Позицијата да е иста ко на овој form
            deckTest.StartPosition = FormStartPosition.Manual;
            deckTest.Location = this.Location;

            //VISIBLE - ја прави невидлива оваа форма. Целта е да се постигне поинтерактивен ефект
            this.Visible = false;
            deckTest.ShowDialog();
            this.Visible = true;
        }

        private void btn_chips_Click(object sender, EventArgs e)
        {
            ChipTesting chipTesting = new ChipTesting();
            //Позицијата да е иста ко на овој form
            chipTesting.StartPosition = FormStartPosition.Manual;
            chipTesting.Location = this.Location;

            //VISIBLE - ја прави невидлива оваа форма. Целта е да се постигне поинтерактивен ефект
            this.Visible = false;
            chipTesting.ShowDialog();
            this.Visible = true;
        }

        private void btn_demo_Click(object sender, EventArgs e)
        {
            Usercreation usercreation = new Usercreation();
            //Позицијата да е иста ко на овој form
            usercreation.StartPosition = FormStartPosition.Manual;
            usercreation.Location = this.Location;

            //VISIBLE - ја прави невидлива оваа форма. Целта е да се постигне поинтерактивен ефект
            this.Visible = false;
            usercreation.ShowDialog();
            this.Visible = true;
        }

        private void btn_deck_MouseEnter(object sender, EventArgs e)
        {
            //Смени изглед во празно
            btn_deck.ForeColor = Color.GhostWhite;
            btn_deck.BackColor = Color.Indigo;
        }
        private void btn_deck_MouseLeave(object sender, EventArgs e)
        {
            //Смени изглед во полно
            btn_deck.ForeColor = Color.Indigo;
            btn_deck.BackColor = Color.GhostWhite;
        }

        private void btn_chips_MouseEnter(object sender, EventArgs e)
        {
            //Смени изглед во празно
            btn_chips.ForeColor = Color.GhostWhite;
            btn_chips.BackColor = Color.Indigo;
        }
        private void btn_chips_MouseLeave(object sender, EventArgs e)
        {
            //Смени изглед во полно
            btn_chips.ForeColor = Color.Indigo;
            btn_chips.BackColor = Color.GhostWhite;
        }

        private void btn_demo_MouseEnter(object sender, EventArgs e)
        {
            //Смени изглед во празно
            btn_demo.ForeColor = Color.GhostWhite;
            btn_demo.BackColor = Color.Indigo;
        }
        private void btn_demo_MouseLeave(object sender, EventArgs e)
        {
            //Смени изглед во полно
            btn_demo.ForeColor = Color.Indigo;
            btn_demo.BackColor = Color.GhostWhite;
        }
    }
}
