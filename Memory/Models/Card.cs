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
    public class CardContainer : Panel
    {

    }

    public class Card : CardContainer
    {
        public int Value { get; set; }
        public Image Image { get; set; }
        public bool IsSelected { get; set; }
        Panel parentPanel;

        public Card currentCard = null;
        Form1 form = new Form1();
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

            foreach (Card c in parentPanel.Controls)
            {
                if (form.isSelectedCounter > 0 && c.IsSelected && form.isSelectedName != c.Name)
                {
                    flipCard.Start();

                    if (c.Value == form.isSelectedValue)
                    {
                        parentPanel.Enabled = false;
                        await Task.Delay(5000);
                        parentPanel.Controls.Remove((Card)parentPanel.Controls.Find(c.Name, true)[0]);
                        parentPanel.Controls.Remove((Card)parentPanel.Controls.Find(form.isSelectedName, true)[0]);
                        parentPanel.Enabled = true;
                    }
                    else
                    {
                        parentPanel.Enabled = false;
                        await Task.Delay(5000);
                        parentPanel.Controls.Find(c.Name, true)[0].BackgroundImage = Resources.back;
                        parentPanel.Controls.Find(form.isSelectedName, true)[0].BackgroundImage = Resources.back;
                        parentPanel.Enabled = true;
                    }
                    
                    form.isSelectedCounter = 0;
                    form.isSelectedValue = 9999;
                    form.isSelectedName = "";
                }
                if (c.IsSelected)
                {
                    form.isSelectedCounter++;
                    Console.WriteLine(form.isSelectedCounter);
                    form.isSelectedValue = c.Value;
                    form.isSelectedName = c.Name;
                }
            }
            form.isSelectedCounter = 0;
            form.isSelectedValue = 9999;
            form.isSelectedName = "";
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
