using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatMenu
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            //If it randomly selects the same color then pick a different one
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
       }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton=(Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        #region Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Console.WriteLine("Hello-----------");
            Console.WriteLine(nameof(sender));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Console.WriteLine("Hello-----------");
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //Console.WriteLine(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //Console.WriteLine(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //Console.WriteLine(sender);
        }
        #endregion
    }
}
