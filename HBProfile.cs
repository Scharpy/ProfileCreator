using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ProfileCreator.HBProfile
{
	/// <summary>
	/// Template for HB Questing Profiles
	/// </summary>
    /// 
	[Serializable]
	[XmlRoot("HBProfile")]
	public class QuestingProfile
	{
		public string Name;
        public int MinLevel;
		public int MaxLevel;
		public string DefaultNavType;
		public decimal MinDurability;
		public int MinFreeBagSlots;
		
		public bool MailGrey;
		public bool MailWhite;
		public bool MailGreen;
		public bool MailBlue;
		public bool MailPurple;
		
		public bool SellGrey;
		public bool SellWhite;
		public bool SellGreen;
		public bool SellBlue;
		public bool SellPurple;

		public bool TargetElites;
    
        public List<Mob> AvoidMobs { get; set; }
        public List<Blackspot> Blackspots { get; set; }
        public List<Mailbox> Mailboxes { get; set; }
        public List<Vendor> Vendors { get; set; }
        //public List<Task> Tasks { get; set; }
        [XmlElement("Quest")]
        public List<QuestOverride> Quests { get; set; }
        [XmlElement("QuestOrder")]
        public List<Quest> QuestOrder { get; set; }

        
        public QuestingProfile(string name)
        {
            this.Name = name;
            AvoidMobs = new List<Mob>();
            Blackspots = new List<Blackspot>();
            Mailboxes = new List<Mailbox>();
            Vendors = new List<Vendor>();
            Quests = new List<QuestOverride>();
            //Tasks = new List<Task>();
        }
        public QuestingProfile()
        {
            AvoidMobs = new List<Mob>();
            Blackspots = new List<Blackspot>();
            Mailboxes = new List<Mailbox>();
            Vendors = new List<Vendor>();
            Quests = new List<QuestOverride>();
            //Tasks = new List<Task>();
        }
    }

    [Serializable]
    public class Mob
	{
        [XmlAttribute]
		public string Name { get; set; }
        [XmlAttribute]
        public int Entry  { get; set; }
		public Mob(string name, int entry)
		{
			Name = name;
			Entry = entry;
		}
        public Mob() { }
	}

    [Serializable]
    public class Blackspot
	{
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public double X { get; set; }
        [XmlAttribute]
        public double Y { get; set; }
        [XmlAttribute]
        public double Z { get; set; }
        [XmlAttribute]
        public double Radius { get; set; }

		public Blackspot(string name, double x, double y, double z, double radius)
		{
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Radius = radius;
		}

		public Blackspot(string name, double x, double y, double z)
		{
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Radius = 21.39;
		}

        public Blackspot() { }

	}

    [Serializable]
    public class Mailbox
	{
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public double X { get; set; }
        [XmlAttribute]
        public double Y { get; set; }
        [XmlAttribute]
        public double Z { get; set; }
        [XmlAttribute]
        public string Nav { get; set; }
        [XmlAttribute]
        public string UsableWhen { get; set; }

        public Mailbox(string name, double x, double y, double z, string nav, string usableWhen)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Nav = nav;
            this.UsableWhen = usableWhen;
        }
        public Mailbox() { }
	}

    [Serializable]
    public class Vendor
	{
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public int Entry { get; set; }
        [XmlAttribute]
        public string Type { get; set; }
        [XmlAttribute]
        public double X { get; set; }
        [XmlAttribute]
        public double Y { get; set; }
        [XmlAttribute]
        public double Z { get; set; }
        [XmlAttribute]
        public string Nav { get; set; }
        [XmlAttribute]
        public bool UsableWhen { get; set; }

        public Vendor(string name, int entry, string type, double x, double y, double z, string nav, bool useableWhen)
        {
            this.Name = name;
            this.Entry = entry;
            this.Type = type;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vendor() { }
	}
		
	[Serializable]
	public class Hotspot
	{
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public double X { get; set; }
        [XmlAttribute]
        public double Y { get; set; }
        [XmlAttribute]
        public double Z { get; set; }

        public Hotspot(string name, double x, double y, double z)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Hotspot(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Hotspot() { }
	}

    [Serializable]
    public class Quest
    {
        public PickUp PickUp;
        public Objective Objective;
        public TurnIn TurnIn;
    }

    [Serializable]
    public class TurnIn
    {
        [XmlAttribute]
        string QuestName;
        [XmlAttribute]
        uint QuestId;
        [XmlAttribute]
        string TurnInName;
        [XmlAttribute]
        uint TurnInId;
        [XmlAttribute]
        string Nav;
    }

    [Serializable]
    public class PickUp
    {
        [XmlAttribute]
        string QuestName;
        [XmlAttribute]
        uint QuestId;
        [XmlAttribute]
        string GiverName;
        [XmlAttribute]
        uint GiverId;
        [XmlAttribute]
        string Nav;
    }

    [Serializable]
    public class QuestOverride
    {
        [XmlAttribute]
        public uint Id;
        [XmlAttribute]
        public string Name;
        public Objective Objective;
        public QuestOverride(uint id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public QuestOverride() { }        
    }

    [Serializable]
    public class Objective
    {
        [XmlAttribute]
        public string Type;
        [XmlAttribute]
        public uint MobId;
        [XmlAttribute]
        public uint KillCount;
        [XmlAttribute]
        public uint CollectCount;
        [XmlAttribute]
        public uint ItemId;
        [XmlAttribute]
        public uint QuestId;

        public List<Collect> CollectFrom;
        public List<Hotspot> Hotspots;

        public Objective(){ }
    }

    [Serializable]
    public class Collect
    {
        public List<Mob> Mobs;
        public List<GameObject> Object;
    }

    [Serializable]
    public class GameObject
    {
        [XmlAttribute]
        public int Id;
        [XmlAttribute]
        public int CollectCount;
    }
}
