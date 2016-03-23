using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpWoWData;

namespace ProfileCreator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            RefreshQuestsCombo();
        }

        private void RefreshQuestsCombo()
        {
            questLogQuestsCombo.Items.Clear();
            foreach (var item in new QuestLogQuests().QuestList())
            {
                questLogQuestsCombo.Items.Add(item);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            RefreshQuestsCombo();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Player me = new Player();
            HotspotListBox.Items.Add("Name = "+HotspotNameTextBox+", X = "+ me.Position().X+", Y = "+ me.Position().Y + ", Z = " + me.Position().Z); //Bug here
        }
    }
}
