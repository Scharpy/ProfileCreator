using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Styx;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;

namespace SharpWoWData
{
    class QuestLogQuests
    {
        static List<PlayerQuest> playerQuest = QuestLog.Instance.GetAllQuests();

        public List<PlayerQuest> PlayerQuests ()
        {
            return playerQuest;
        }

        public string[] QuestList()
        {
            List<string> _questList = new List<string>();
            foreach (var quest in PlayerQuests())
            {
                _questList.Add(quest.Id.ToString() + " - " + quest.Name.ToString());
            }
            return _questList.ToArray();
        }

        public string[] Objectives(int index)
        {
            return PlayerQuests()[index].Objectives;
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

        public WoWPoint Position()
        {            
            WoWPoint position = new WoWPoint();
            position.X = Me.X;
            position.Y = Me.Y;
            position.Z = Me.Z;
            return position;
        }

        public float X()
        {
            return Position().X;
        }

        public float Y()
        {
            return Position().Y;
        }

        public float Z()
        {
            return Position().Z;
        }
    }
}
