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

        public async void Card_Click(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
            Enabled = false;
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

            int isSelectedCounter = 0;
            int isSelectedValue = 9999;
            string isSelectedName = "";

            foreach (Card c in parentPanel.Controls)
            {
                if (isSelectedCounter > 0 && c.IsSelected && isSelectedName != c.Name)
                {
                    flipCard.Start();

                    if (c.Value == isSelectedValue)
                    {
                        parentPanel.Enabled = false;
                        await Task.Delay(5000);
                        parentPanel.Controls.Remove((Card)parentPanel.Controls.Find(c.Name, true)[0]);
                        parentPanel.Controls.Remove((Card)parentPanel.Controls.Find(isSelectedName, true)[0]);
                        parentPanel.Enabled = true;
                    }
                    else
                    {
                        parentPanel.Enabled = false;
                        await Task.Delay(5000);
                        ((Card)parentPanel.Controls.Find(c.Name, true)[0]).BackgroundImage = Resources.back;
                        ((Card)parentPanel.Controls.Find(isSelectedName, true)[0]).BackgroundImage = Resources.back;
                        parentPanel.Enabled = true;
                        ((Card)parentPanel.Controls.Find(c.Name, true)[0]).IsSelected = false;
                        ((Card)parentPanel.Controls.Find(isSelectedName, true)[0]).IsSelected = false;
                    }
                    isSelectedCounter = 0;
                    isSelectedValue = 9999;
                    isSelectedName = "";
                }
                if (c.IsSelected)
                {
                    isSelectedCounter++;
                    Console.WriteLine(isSelectedCounter);
                    isSelectedValue = c.Value;
                    isSelectedName = c.Name;
                }
            }
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
