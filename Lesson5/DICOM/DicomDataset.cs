using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DICOM
{
    public class DicomElement(string groupId, string elementId, string vr, string description)
    {
        public string GroupId { get; set; } = groupId;
        public string ElementId { get; set; } = elementId;
        public string Vr { get; set; } = vr;
        public string Description { get; set; } = description;
    }

    public class DicomXmlFile : List<DicomElement>
    {
        public DicomXmlFile(string filename)
        {
            XmlDocument xmlDoc = new();
            xmlDoc.Load(filename);

            XmlElement root = xmlDoc.DocumentElement;
            foreach (XmlNode node in root)
            {
                if (node.Attributes.Count <= 0) continue;

                XmlNode group = node.Attributes.GetNamedItem("GroupID");
                if (group == null) continue;

                XmlNode element = node.Attributes.GetNamedItem("ElementID");
                if (element == null) continue;

                string vr = string.Empty;
                string name = string.Empty;

                foreach (XmlNode childNode in node.ChildNodes)
                {
                    switch (childNode.Name)
                    {
                        case "VR":
                            vr = childNode.InnerText;
                            break;
                        case "Name":
                            name = childNode.InnerText;
                            break;
                    }
                }

                Add(new DicomElement(group.Value, element.Value, vr, name));
            }
        }

        public DicomElement GetData(string groupId, string elementId)
        {
            DicomElement result;

            if (elementId == "0000")
            {
                result = new DicomElement(groupId, elementId, "UL", "Group Length");
            }
            else
            {
                int index = 0;
                while (index < Count && this[index].GroupId != groupId || this[index].ElementId != elementId)
                {
                    index++;
                }

                result = (index == Count) ? new DicomElement(groupId, elementId, "UN", "User Data") : this[index];
            }

            return result;
        }
    }
}
