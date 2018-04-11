// Paolo T. Inocencion
// COSC 420 Special Topics
// Elephant Application
// April 11, 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantApplication
{
    class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " 
                + EarSize + " inches tall.", Name + " says ...");

        }

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " says: " + message);

        }

        public void SpeakTo(Elephant whoTalkTo, string message)
        {
            whoTalkTo.TellMe(message, this);
        }
    }
}
