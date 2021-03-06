﻿using System;
using System.Collections.Generic;
using System.Drawing;
namespace RTiVo_Windows
{
    partial class MainWindow
    {
        public static List<StationButton> availableButtons = new List<StationButton>();
        public static int buttonSize = 100;
        public static int buttonBorder = 2;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(986, 1006);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(986, 1006);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "RTiVo";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public void addButtons(StationList stationList)
        {
            Boolean firstButtonAdded = true;
            List<Station> sList = stationList.getAvailableStations();
            sList.Sort();
            foreach(Station s in sList)
            {
                var button = new StationButton(s.getFrequency());
                button.Text = s.getName();
                button.Width = buttonSize;
                button.Height = button.Width;
                button.Margin = new System.Windows.Forms.Padding(buttonBorder, buttonBorder, buttonBorder, buttonBorder);
            
                flowLayoutPanel1.Controls.Add(button);
                availableButtons.Add(button);
                if (firstButtonAdded)
                {
                    firstButtonAdded = false;
                    button.selectAndTune();
                }
            }
            var buttonAdd = new StationButton(-1);
            buttonAdd.Text = "+";
            buttonAdd.Width = buttonSize;
            buttonAdd.Height = buttonAdd.Width;
            buttonAdd.Margin = new System.Windows.Forms.Padding(buttonBorder, buttonBorder, buttonBorder, buttonBorder);

            flowLayoutPanel1.Controls.Add(buttonAdd);
            availableButtons.Add(buttonAdd);
            int rowOffset = 39;
            int colOffset = 17;
            int elementsPerRow = 5;
            int numRows = (sList.Count + 1)/ elementsPerRow;
            if((sList.Count+1)%elementsPerRow != 0)
            {
                numRows++;
            }
            int elementSize = (buttonSize + 2 * buttonBorder);
            this.Height = elementSize * numRows+ rowOffset;
            this.Width = elementSize * elementsPerRow + colOffset;
        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

