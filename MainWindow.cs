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
            foreach (var item in new QuestLogQuests().QuestList())
            {
                questLogQuestsCombo.Items.Clear();
                questLogQuestsCombo.Items.Add(item);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            RefreshQuestsCombo();
        }
    }
}
