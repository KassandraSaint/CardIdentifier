using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardIdentifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardPic1_Click(object sender, EventArgs e)
        {
            // Show text 'Joker' when first card is clicked
            showCard.Text = "Joker";
        }

        private void cardPic2_Click(object sender, EventArgs e)
        {
            // Show text 'Queen of Diamonds' when second card is clicked
            showCard.Text = "Queen of Diamonds";
        }

        private void cardPic3_Click(object sender, EventArgs e)
        {
            // Show text 'Ace of Spades' when third card is clicked
            showCard.Text = "Ace of Spades";
        }

        private void cardPic4_Click(object sender, EventArgs e)
        {
            // Show text 'Jack of Hearts' when fourth card is clicked
            showCard.Text = "Jack of Hearts";
        }

        private void cardPic5_Click(object sender, EventArgs e)
        {
            // Show text 'King of Clubs' when fifth card is clicked
            showCard.Text = "King of Clubs";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
