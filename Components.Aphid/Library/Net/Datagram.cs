﻿using Components.Aphid.TypeSystem;

namespace Components.Aphid.Library.Net
{
    public class Datagram
    {
        [AphidProperty("localPort")]
        public int LocalPort { get; set; }

        [AphidProperty("remotePort")]
        public int RemotePort { get; set; }

        [AphidProperty("remoteHost")]
        public string RemoteHost { get; set; }

        [AphidProperty("data")]
        public byte[] Data { get; set; }
    }
}
