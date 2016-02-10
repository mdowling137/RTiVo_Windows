using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace RTiVo_Windows
{
    public class StationButton : Button
    {
        private Boolean selected;
        private Color unselectedColor = Color.LightBlue;
        private Color selectedColor = Color.DodgerBlue;
        private int frequency;
        public StationButton(int freq)
        : base()
    {
            this.selected = false;
            this.BackColor = unselectedColor;
            this.Click += this.clickHandler;
            this.frequency = freq;
        }

        protected void clickHandler(object sender, EventArgs e)
        {
            selectAndTune();
            
        }
       
        public void selectAndTune()
        {
            foreach (StationButton b in MainWindow.availableButtons)
            {
                if (b != this)
                {
                    b.BackColor = unselectedColor;
                    b.selected = false;
                }
            }
            if (this.selected != true)
            {
                System.Diagnostics.Debug.WriteLine("Sending serial tune command with frequency argument: " + frequency);
                //ADD SERIAL COMMAND HERE TO TALK TO ARDUINO
                this.BackColor = selectedColor;
                this.selected = true;
            }
        }
    }
}
