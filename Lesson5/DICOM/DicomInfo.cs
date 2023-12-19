using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICOM
{
    public class DicomInfo : List<DicomDataset>
    {
        private readonly string _filename;
        private readonly BinaryReader _reader;
        private bool isExplicitVR;

        public Encoding encoding;

        public const int Preamble = 128;
        public const int DicomPrefix = 4;

        public DicomInfo(string filename, DicomXmlFile dicomElements)
        {
            _filename = filename;
            _reader = new BinaryReader(File.Open(_filename, FileMode.Open));
            encoding = Encoding.ASCII;

            if (!IsDicom())
            {
                _reader.Close();
                throw new FormatException("Isn't a DICOM file");
            }

            _reader.ReadBytes(8);
            UInt32 length0002 = _reader.ReadUInt32();
            Add(new DicomDataset(dicomElements.GetData("0002", "0000"), 4, BitConverter.GetBytes(length0002), this));

            Int64 group0002End = _reader.BaseStream.Position + length0002;

            while (_reader.BaseStream.Position < group0002End)
            {
                string groupId = _reader.ReadInt16().ToString("X4");
                string elementId = _reader.ReadInt16().ToString("X4");
                string vr = Encoding.ASCII.GetString(_reader.ReadBytes(2));

                UInt32 length = ReadLength(vr);
                byte[] data = _reader.ReadBytes((int)length);

                Add(new DicomDataset(dicomElements.GetData(groupId, elementId), length, data, this));
            }

            // Explicit or Implicit

            // цикл while до 8 Group 2111 Element
        }

        public bool IsDicom()
        {
            _reader.ReadBytes(Preamble);
            byte[] data = _reader.ReadBytes(DicomPrefix);
            string s = Encoding.ASCII.GetString(data);
            return s == "DICM";
        }

        private uint ReadLength(string vr)
        {
            uint result;

            if (vr == "OB" || vr == "OW" || vr == "UN" || vr == "UT" || vr == "SQ")
            {
                _reader.ReadBytes(2);

                result = _reader.ReadUInt32();
            }
            else
            {
                result = _reader.ReadUInt16();
            }

            return result;
        }
    }

    public class DicomDataset(DicomElement dicomElement, uint length, byte[] data, DicomInfo parent)
    {
        public DicomElement DicomElement = dicomElement;
        public UInt32 Length { get; set; } = length;
        public byte[] Data = data;

        public string DataStr => GetDataStr(parent.encoding);
        public string DicomElementGroupId => DicomElement.GroupId;
        public string DicomElementElementId => DicomElement.ElementId;
        public string DicomElementVr => DicomElement.Vr;
        public string DicomElementDescription => DicomElement.Description;

        private string GetDataStr(Encoding encoding)
        {
            string result;

            switch (DicomElement.Vr)
            {
                case "SS":
                    result = BitConverter.ToInt16(Data, 0).ToString();
                    break;
                case "US":
                    result = BitConverter.ToUInt16(Data, 0).ToString();
                    break;
                case "SL":
                    result = BitConverter.ToInt32(Data, 0).ToString();
                    break;
                case "UL":
                    result = BitConverter.ToUInt32(Data, 0).ToString();
                    break;
                case "FL":
                    result = BitConverter.ToSingle(Data, 0).ToString(CultureInfo.InvariantCulture);
                    break;
                case "FD":
                    result = BitConverter.ToDouble(Data, 0).ToString(CultureInfo.InvariantCulture);
                    break;
                default:
                    result = encoding.GetString(Data);
                    break;
            }

            return result.Trim(Convert.ToChar(0));
        }
    }
}
