﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTiVo_Windows
{
    public partial class CustomStation : Form
    {
        public CustomStation(Control Parent)
        {
            InitializeComponent();
            this.Location = new Point(Parent.Location.X + 100, Parent.Location.Y + 100);
            
        }
    }
}
