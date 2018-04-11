﻿// Paolo T. Inocencion
// COSC 420 Special Topics
// Elephant Application
// April 11, 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantApplication
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;


        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant()
            {
                Name = "Lucinda",
                EarSize = 33

            };

            lloyd = new Elephant()
            {
                Name = "Lloyd",
                EarSize = 40

            };
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
            Elephant[] elephants = new Elephant[7];
            elephants[0] = new Elephant() { Name = "Lloyd", EarSize = 40 };
            elephants[1] = new Elephant() { Name = "Lucinda", EarSize = 33 };
            elephants[2] = new Elephant() { Name = "Larry", EarSize = 42 };
            elephants[3] = new Elephant() { Name = "Lucille", EarSize = 32 };
            elephants[4] = new Elephant() { Name = "Lars", EarSize = 44 };
            elephants[5] = new Elephant() { Name = "Linda", EarSize = 37 };
            elephants[6] = new Elephant() { Name = "Humphrey", EarSize = 45 };

            Elephant biggestEars = elephants[0];

            for (int i = 1; i < elephants.Length; i++)
            {
                if (elephants[i].EarSize > biggestEars.EarSize)
                {
                    biggestEars = elephants[i];
                }
            }
            MessageBox.Show(biggestEars.EarSize.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant backup;
            backup = lloyd;
            lloyd = lucinda;
            lucinda = backup;
            MessageBox.Show("Objects swapped.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hi", lucinda);
            lloyd.SpeakTo(lucinda, "Hello!");
            lloyd = lucinda;
            lloyd.EarSize = 9678;
            lloyd.WhoAmI();
        }
    }
}
