using DATReader.DatStore;
using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ROMVault.Helpers
{
    public static class Xml
    {
        public static void WriteNewDatXml(string filePath, DatHeader datHeader)
        {
            if (datHeader == null)
                throw new ArgumentNullException(nameof(datHeader));

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = false,
                Encoding = new UTF8Encoding(true)
            };

            using (XmlWriter writer = XmlWriter.Create(filePath, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("datafile");
                writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");

                writer.WriteStartElement("header");
                writer.WriteElementString("name", datHeader.Name ?? string.Empty);
                writer.WriteElementString("description", datHeader.Description ?? string.Empty);
                writer.WriteElementString("version", datHeader.Version ?? string.Empty);
                writer.WriteElementString("author", datHeader.Author ?? string.Empty);
                writer.WriteElementString("category", datHeader.Category ?? string.Empty);
                writer.WriteEndElement();

                // Boilerplate game element with dummy ROM entry
                writer.WriteStartElement("game");
                writer.WriteAttributeString("name", "Dummy (delete after adding another rom)");
                writer.WriteStartElement("rom");
                writer.WriteAttributeString("name", "Dummy.rom");
                writer.WriteAttributeString("size", "0");
                writer.WriteAttributeString("crc", "0");
                writer.WriteAttributeString("md5", "0");
                writer.WriteAttributeString("sha1", "0");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}