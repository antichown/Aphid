﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Components
{
    public static class AssemblyExtension
    {
        public static DateTime GetLinkTime(this Assembly asm)
        {
            var t = asm.GetLinkTimeUtc();

            return t != default ? t.ToLocalTime() : t;
        }

        public static DateTime GetLinkTimeUtc(this Assembly asm)
        {
            FileStream file;

            const int peHeaderOffset = 60;

            if ((file = asm.GetFiles().FirstOrDefault()) == null ||
                file.Length < peHeaderOffset + 4)
            {
                return default;
            }

            file.Position = peHeaderOffset;
            var reader = new BinaryReader(file);
            var linkDateOffset = reader.ReadInt32() + 8;

            if (file.Length < linkDateOffset + 4)
            {
                return default;
            }

            file.Position = linkDateOffset;

            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                .AddSeconds(reader.ReadInt32());
        }

        public static Type[] TryGetTypes(this Assembly asm)
        {
            try
            {
                return asm.GetTypes();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);

                return null;
            }
        }
    }
}
