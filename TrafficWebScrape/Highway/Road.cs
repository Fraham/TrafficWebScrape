﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TrafficWebScrape.Highway
{
    public class Road
    {
        private string name;

        private static List<Road> roads;

        private static string filename = "roads.xml";

        public Road(string name)
        {
            Name = name;
        }

        public static List<Road> GetAll()
        {
            return Roads;
        }

        private static Road DecodeName(string roadName)
        {
            Road road;

            if (roadName.StartsWith("M"))
            {
                road = new Motorway(roadName);
            }
            else if (roadName.StartsWith("A"))
            {
                road = new ARoad(roadName);
            }
            else
            {
                road = new Road(roadName);
            }

            return road;
        }

        public static Road NewRoad(string roadName)
        {
            Road road;

            if (roadName.StartsWith("M"))
            {
                road = new Motorway(roadName);
            }
            else if (roadName.StartsWith("A"))
            {
                road = new ARoad(roadName);
            }
            else
            {
                road = new Road(roadName);
            }

            Roads.Add(road);
            Save();

            return road;
        }

        public static Road GetRoad(string roadName)
        {
            foreach (Road road in Roads)
            {
                if (road.Name.Equals(roadName))
                {
                    return road;
                }
            }

            return NewRoad(roadName);
        }

        public static void Load()
        {
            Load(filename);
        }

        private static void ProcessReader(XmlReader reader)
        {
            if (reader.Read())
            {
                switch (reader.Name)
                {
                    case "Name":
                        if (reader.Read())
                        {
                            Roads.Add(DecodeName(reader.Value.Trim()));
                        }
                        break;
                }
            }
        }

        public static void Load(string filename)
        {
            try
            {
                using (XmlReader reader = XmlReader.Create(filename))
                {
                    while (reader.Read())
                    {
                        // Only detect start elements.
                        if (reader.IsStartElement())
                        {
                            // Get element name and switch on it.
                            switch (reader.Name)
                            {
                                case "Road":
                                case "ARoad":
                                case "Motorway":
                                    ProcessReader(reader);
                                    break;
                            }
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {

            }
        }

        public static void Save()
        {
            Save(filename);
        }

        public static void Save(string filename)
        {
            using (XmlWriter writer = XmlWriter.Create(filename))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Roads");

                foreach (Road road in Roads)
                {
                    string roadType = "Road";
                    if (road is Motorway)
                    {
                        roadType = "Motorway";
                    }
                    else if (road is ARoad)
                    {
                        roadType = "ARoad";
                    }

                    writer.WriteStartElement(roadType);

                    writer.WriteElementString("Name", road.Name);

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value == null | value.Equals(""))
                {
                    value = "Unknown";
                }
                name = value;
            }
        }

        public static List<Road> Roads
        {
            get
            {
                if (roads == null)
                {
                    roads = new List<Road>();
                }
                return roads;
            }

            set
            {
                roads = value;
            }
        }

        public static string Filename
        {
            get
            {
                return filename;
            }

            set
            {
                filename = value;
            }
        }

        public new string ToString
        {
            get
            {
                return Name;
            }
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Road other = obj as Road;

            if (other == null)
            {
                return false;
            }

            if (!Name.Equals(other.Name))
            {
                return false;
            }

            return true;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
