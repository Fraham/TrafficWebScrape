using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TrafficWebScrape.Highway
{
    class Road
    {
        private string name;

        private static List<Road> roads;

        private static string filename = "roads.xml";

        public Road(string name)
        {
            Name = name;
        }

        public static Road newRoad(string roadName)
        {
            Road road = new Road(roadName);
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

            return newRoad(roadName);
        }

        public static void Load()
        {
            Load(filename);
        }

        public static void Load(string filename)
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
                            case "Roads":
                                // Detect this element.
                                Console.WriteLine("Start <Roads> element.");
                                break;
                            case "Road":
                                // Detect this article element.
                                Console.WriteLine("Start <Road> element.");
                                // Search for the attribute name on this current node.
                                string attribute = reader["name"];
                                if (attribute != null)
                                {
                                    Console.WriteLine("  Has attribute name: " + attribute);
                                }
                                // Next read will contain text.
                                if (reader.Read())
                                {
                                    switch (reader.Name)
                                    {
                                        case "Name":
                                            Roads.Add(new Road(reader.Value.Trim()));
                                            break;
                                    }
                                }
                                break;
                        }
                    }
                }
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
                    writer.WriteStartElement("Road");

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

        internal static List<Road> Roads
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
    }
}
