using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace SignatureScrapper
{
    public static class UriFileStream
    {
        public static List<string> FindBmpPaths(string uriString)
        {
            List<string> urnList = new List<string>();

            var client = new WebClient();
            char[] buffer;

            using (var stream = client.OpenRead(uriString))
            using (var reader = new StreamReader(stream))
            {

                reader.ReadLine();
                reader.ReadLine();

                //(int)reader.BaseStream.Length
                buffer = new char[1500];
                reader.ReadBlock(buffer, 0, 1500);

                //var text = reader.ReadLine();
                var text = new string(buffer);
                var splitText = text.Split('"', '/');

                foreach (var item in splitText)
                {
                    if (item.Contains(".bmp") && !item.Contains(">")) urnList.Add(item);
                }
            }
            return urnList;
        }
    }
}
