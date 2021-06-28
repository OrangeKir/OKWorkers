namespace OKWorkers.Controller
{
    using System.IO;
    using System.Xml;

    public class IOHelper
    {
        public static void ReadFile(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                ReadData(stream);
            }
        }
        private static void ReadData(Stream stream)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(stream);
        }
    }
}