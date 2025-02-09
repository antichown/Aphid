using System;
using System.Text;
using Microsoft.Pex.Framework;

namespace System.IO
{
    /// <summary>A factory for System.IO.TextWriter+SyncTextWriter instances</summary>
    public static partial class TextWriterFactory
    {
        /// <summary>A factory for System.IO.TextWriter+SyncTextWriter instances</summary>
        [PexFactoryMethod(typeof(GC), "System.IO.TextWriter+SyncTextWriter")]
        public static IDisposable CreateSyncTextWriter()
        {
            return new StringWriter(new StringBuilder());

            // TODO: Edit factory method of SyncTextWriter
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
