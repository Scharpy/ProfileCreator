using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Styx;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;
using ProfileCreator.HBProfile;

namespace SharpWoWData
{
    class QuestLogQuests
    {
        public QuestLogQuests()
        {
            
        }

        public List<ProfileCreator.HBProfile.Quest> PlayerQuests ()
        {            
            List<PlayerQuest> playerQuest = QuestLog.Instance.GetAllQuests();
            List<ProfileCreator.HBProfile.Quest> SharpQuest = new List<ProfileCreator.HBProfile.Quest>();
            foreach (var a in playerQuest)
            {
                SharpQuest.Add(new ProfileCreator.HBProfile.Quest(a.Id, a.Name));
            }
            return SharpQuest;
        }

        public string[] QuestList()
        {
            List<string> _questList = new List<string>();
            foreach (var item in PlayerQuests())
            {
                _questList.Add(item.Id.ToString() + " - " + item.Name.ToString());
            }
            return _questList.ToArray();
        }
    }
    class Player
    {
        private static LocalPlayer Me = StyxWoW.Me;
        public string TargetName()
        {
            return Me.CurrentTarget.Name;
        }
        public uint TargetEntry()
        {
            return Me.CurrentTarget.Entry;
        }
        public Hotspot Position()
        {            
            Hotspot position = new Hotspot();
            position.X = Convert.ToDouble(Me.X);
            position.Y = Convert.ToDouble(Me.Y);
            position.Z = Convert.ToDouble(Me.Z);
            return position;
        }
    }
}
