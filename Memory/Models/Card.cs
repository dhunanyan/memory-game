﻿using System;
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

        private void Card_Click(object sender, EventArgs e)
        {
            
        }

    }
}
