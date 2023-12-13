using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICOM
{
    public class DicomInfo : List<DicomElementInfo>
    {
        private readonly string _filename;
        private readonly BinaryReader _reader;

        public const int Preamble = 128;
        public const int DicomPrefix = 4;

        public DicomInfo(string filename, DicomXmlFile dicomElements)
        {
            _filename = filename;
            _reader = new BinaryReader(File.Open(_filename, FileMode.Open));

            if (!IsDicom())
            {
                _reader.Close();
                throw new FormatException("Isn't a DICOM file");
            }

            _reader.ReadBytes(8);
            UInt32 length0002 = _reader.ReadUInt32();
            Add(new DicomElementInfo(dicomElements.GetData("0002", "0000"), 4, BitConverter.GetBytes(length0002)));

            Int64 group0002End = _reader.BaseStream.Position + length0002;

            while (_reader.BaseStream.Position < group0002End)
            {
                _reader.ReadInt16(); // groupId
                _reader.ReadInt16(); // elementId
                Encoding.ASCII.GetString(_reader.ReadBytes(2)); // vr
            }
        }

        public bool IsDicom()
        {
            _reader.ReadBytes(Preamble);
            byte[] data = _reader.ReadBytes(DicomPrefix);
            string s = Encoding.ASCII.GetString(data);
            return s == "DICM";
        }
    }

    public class DicomElementInfo
    {
        public DicomElement dicomElement;
        public UInt32 length;
        public byte[] data;

        public DicomElementInfo(DicomElement dicomElement, uint length, byte[] data)
        {
            this.dicomElement = dicomElement;
            this.length = length;
            this.data = data;
        }
    }
}
