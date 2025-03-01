﻿using Components.Aphid.TypeSystem;
using System.IO;
using System.Text;

namespace Components.Aphid.Library.Net.Http
{
    public class AphidUpload
    {
        [AphidProperty("name")]
        public string Name { get; set; }

        [AphidProperty("filename")]
        public string Filename { get; set; }

        [AphidProperty("text")]
        public string Text { get; set; }

        public HttpUpload ToHttpUpload()
        {
            var upload = new HttpUpload
            {
                Name = Name,
                Filename = Filename
            };

            if (Text != null)
            {
                upload.Stream = new MemoryStream(Encoding.UTF8.GetBytes(Text));
            }
            else
            {
                upload.Stream = File.OpenRead(Filename);
            }

            return upload;
        }
    }
}
