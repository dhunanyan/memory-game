using Memory.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory.Models
{
    public class Card : Panel
    {
        public int Value { get; set; }
        public Image Image { get; set; }
        public bool IsSelected { get; set; }
        Panel parentPanel;

        public Card currentCard = null;
        int currentCardWidth;
        int cardWidthZero = 0;
        private System.ComponentModel.IContainer components = null;
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flipCard = new Timer(components);
            flipCard.Tick += new EventHandler(FlipCard);
            flipCard.Interval = 1;
        }

        public Card(int width, bool isSelected, int value, Panel panel)
        {
            InitializeComponent();
            Width = width;
            currentCardWidth = width;
            IsSelected = isSelected;
            Value = value;
            parentPanel = panel;
        }

        public void Card_Click(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
            Enabled = false;
            currentCard = (Card)sender;
            if (!IsSelected)
            {

                flipCard.Start();
                BackgroundImage = (Image)Resources.ResourceManager.GetObject("_" + Value.ToString());
                IsSelected = true;
            }
            else
            {
                flipCard.Start();
                BackgroundImage = (Image)Resources.ResourceManager.GetObject("back");
                IsSelected = false;
            }

            //int selectedValue = 99999;
            //foreach (Card c in parentPanel.Controls)
            //{
            //    Console.WriteLine(c.Value);
            //    if (c.IsSelected == true)
            //    {
            //        if (selectedValue == 99999)
            //        {
            //            selectedValue = c.Value;
            //        }
            //        else
            //        {
            //            if (currentCard.IsSelected == c.IsSelected)
            //            {
            //                currentCard.BackgroundImage = (Image)Resources.ResourceManager.GetObject("back");
            //                c.BackgroundImage = (Image)Resources.ResourceManager.GetObject("back");
            //                selectedValue = 99999;
            //            }
            //        }
            //    }
            //}
        }

        private void FlipCard(object sender, EventArgs e)
        {
            cardWidthZero += 10;
            Size = new Size(cardWidthZero, Height);
            if (cardWidthZero >= currentCardWidth)
            {
                Enabled = true;
                Size = new Size(currentCardWidth, Height);
                BorderStyle = BorderStyle.Fixed3D;
                cardWidthZero = 0;
                flipCard.Stop();
            }
        }
        public Timer flipCard;
    }
}
