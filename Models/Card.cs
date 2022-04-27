using Profile.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile.Models
{ 

    public class Card : Panel
    {
        public int Value { get; set; }
        public Image Image { get; set; }
        public bool IsSelected { get; set; }

        Panel parentPanel;  
        int currentCardWidth;
        int cardWidthZero = 0;
        public int currentShowTimeout;
        private System.ComponentModel.IContainer components = null;
        Button buttonShow;
        Button buttonStart;
        Button buttonRestart;
        public ComboBox comboBoxShowTimeout;
        public static int currentMoves = 0;
        public Container container = new Profile.Container();

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            flipCard = new Timer(components);
            flipCard.Tick += new EventHandler(FlipCard);
            flipCard.Interval = 1;
        }

        public Card(int width, bool isSelected, int value, Panel panel, Button buttonShow, Button buttonStart, Button buttonRestart)
        {
            InitializeComponent();
            Width = width;
            currentCardWidth = width;
            IsSelected = isSelected;
            Value = value;
            parentPanel = panel;
            this.buttonStart = buttonStart;
            this.buttonShow = buttonShow;
            this.buttonRestart = buttonRestart;
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
                buttonStart.Enabled = false;
                buttonShow.Enabled = false;
                buttonRestart.Enabled = false;
                comboBoxShowTimeout.Enabled = false;

                currentMoves++;
                container.CurrentMoves = currentMoves.ToString();
                Console.WriteLine(container.CurrentMoves);
            }
            else
            {
                flipCard.Start();
                BackgroundImage = (Image)Resources.ResourceManager.GetObject("backBlack");

                IsSelected = false;
                buttonStart.Enabled = true;
                buttonShow.Enabled = true;
                buttonRestart.Enabled = true;
                comboBoxShowTimeout.Enabled = true;
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
                        Console.WriteLine(currentShowTimeout);
                        buttonStart.Enabled = false;
                        buttonShow.Enabled = false;
                        parentPanel.Enabled = false;
                        buttonRestart.Enabled = false;
                        comboBoxShowTimeout.Enabled = false;

                        await Task.Delay(currentShowTimeout * 1000);

                        parentPanel.Controls.Remove((Card)parentPanel.Controls.Find(c.Name, true)[0]);
                        parentPanel.Controls.Remove((Card)parentPanel.Controls.Find(isSelectedName, true)[0]);

                        parentPanel.Enabled = true;
                        buttonStart.Enabled = true;
                        buttonShow.Enabled = true;
                        buttonRestart.Enabled = true;
                        comboBoxShowTimeout.Enabled = true;
                    }
                    else
                    {
                        buttonStart.Enabled = false;
                        buttonShow.Enabled = false;
                        parentPanel.Enabled = false;
                        buttonRestart.Enabled = false;
                        comboBoxShowTimeout.Enabled = false;

                        await Task.Delay(currentShowTimeout * 1000);

                        ((Card)parentPanel.Controls.Find(c.Name, true)[0]).BackgroundImage = Resources.backBlack;
                        ((Card)parentPanel.Controls.Find(isSelectedName, true)[0]).BackgroundImage = Resources.backBlack;

                        ((Card)parentPanel.Controls.Find(c.Name, true)[0]).IsSelected = false;
                        ((Card)parentPanel.Controls.Find(isSelectedName, true)[0]).IsSelected = false;

                        parentPanel.Enabled = true;
                        buttonStart.Enabled = true;
                        buttonShow.Enabled = true;
                        buttonRestart.Enabled = true;
                        comboBoxShowTimeout.Enabled = true;
                    }
                    isSelectedCounter = 0;
                    isSelectedValue = 9999;
                    isSelectedName = "";
                }
                if (c.IsSelected)
                {
                    isSelectedCounter++;
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
