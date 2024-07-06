using System;
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
    public partial class Payment : Form
    {
        public PaymentCard playercard;
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (playercard != null)
            {
                mtb_cardnumber.Text = playercard.CardNumber;
                mtb_expirationdate.Text = playercard.ExpirationDate;
                mtb_ccv.Text = playercard.CCV;
                nud_amount.Value = playercard.Amount;
            }
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            //if (mtb_cardnumber.MaskCompleted && mtb_expirationdate.MaskCompleted) //вака не може да бидат 0
                string cardnumber = mtb_cardnumber.Text;
                string expirationdate = mtb_expirationdate.Text;
                string ccv = mtb_ccv.Text;
                int amount = (int)nud_amount.Value; //Враќа decimal

                playercard = new PaymentCard(cardnumber, ccv, expirationdate, amount);

            DialogResult = DialogResult.OK;
        }
    }
}
