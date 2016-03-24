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
        private MainWindow mainForm;
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
                return new Version(0, 0, 2);
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
            if (mainForm == null || mainForm.IsDisposed)
                mainForm = new MainWindow();
            try
            {
                mainForm.Show();
                mainForm.Activate();
            }
            catch (ArgumentOutOfRangeException ee)
            {

            }
        }
    }
}
