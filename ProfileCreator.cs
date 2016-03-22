using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Styx;
using Styx.Plugins;
using Styx.Common;
using SharpWoWData;
using Styx.WoWInternals;
using System.Drawing;
using System.Windows.Media;

namespace ProfileCreator
{
    public class QuestCreator : HBPlugin
    {
        public override string Author
        {
            get
            {
                return "Sharpy";
            }
        }
        public override string Name
        {
            get
            {
                return "@ProfileCreator";
            }
        }
        public override string ButtonText
        {
            get
            {
                return "Menu";
            }
        }
        public override Version Version
        {
            get
            {
                return new Version(0, 0, 1);
            }
        }
        public override void Pulse()
        {
            return;
        }
        public override void OnEnable()
        {
            Logging.Write("ProfileCreator enabled version " + Version.ToString(), Colors.Green );
        }
        public override void OnDisable()
        {
            Logging.Write("ProfileCreator disabled.", Colors.Blue);
        }
        public override bool WantButton
        {
            get
            {
                return true;
            }
        }
        public override void OnButtonPress()
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
