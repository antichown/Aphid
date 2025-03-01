﻿using System.IO;

namespace Components.Aphid.Library.Net.Http
{
    public class HttpResponse : HttpMessagePart
    {
        public bool IsChunked { get; set; }

        public Stream BodyStream { get; set; }

        public string GetBodyString()
        {
            BodyStream.Position = 0;

            Stream stream;

            if (IsChunked)
            {
                stream = new MemoryStream();
                ChunkedTransferEncoding.Decode(BodyStream, stream);
            }
            else
            {
                stream = BodyStream;
            }

            return new StreamReader(stream).ReadToEnd();
        }
    }
}
