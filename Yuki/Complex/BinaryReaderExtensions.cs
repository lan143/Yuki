//Copyright (C) 2012 WoW-Mig <http://www.wow-mig.ru/>
//This file is free software; as a special exception the author gives
//unlimited permission to copy and/or distribute it, with or without
//modifications, as long as this notice is preserved.

//This program is distributed in the hope that it will be useful, but
//WITHOUT ANY WARRANTY, to the extent permitted by law; without even the
//implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Yuki.Complex
{
    public static class BinaryReaderExtensions
    {
        public static bool CanRead(this BinaryReader reader, int bytes)
        {
            return (reader.BaseStream.GetRemainingLength() >= bytes);
        }

        public static bool CanRead(this Stream stream, int bytes)
        {
            return (stream.GetRemainingLength() >= bytes);
        }

        public static long GetRemainingLength(this BinaryReader reader)
        {
            return reader.BaseStream.GetRemainingLength();
        }

        public static long GetRemainingLength(this Stream stream)
        {
            return (stream.Length - stream.Position);
        }

        public static bool IsRead(this BinaryReader reader)
        {
            return (reader.GetRemainingLength() == 0L);
        }

        public static bool IsRead(this Stream stream)
        {
            return (stream.GetRemainingLength() == 0L);
        }

        public static string ReadCString(this BinaryReader reader)
        {
            return reader.ReadCString(Encoding.UTF8);
        }

        public static string ReadCString(this BinaryReader reader, Encoding encoding)
        {
            byte num;
            List<byte> list = new List<byte>();
            while ((num = reader.ReadByte()) != 0)
            {
                list.Add(num);
            }
            return encoding.GetString(list.ToArray());
        }

        public static string ReadEscapeCString(this BinaryReader reader)
        {
            string valval = Regex.Replace(reader.ReadCString(), @"'", @"\'");
            valval = Regex.Replace(valval, "\"", "\\\"");
            if (valval != null)
                return valval;
            else
                return "null";
        }

        public static void SkipBytes(this BinaryReader reader, int count)
        {
            reader.BaseStream.SkipBytes(count);
        }

        public static void SkipBytes(this Stream stream, int count)
        {
            if (!stream.CanRead(count))
            {
                throw new ArgumentOutOfRangeException("count");
            }
            stream.Position += count;
        }

        public static string ReadEscapePascalString(this BinaryReader reader)
        {
            string valval = Regex.Replace(reader.ReadPascalString(), @"'", @"\'");
            valval = Regex.Replace(valval, "\"", "\\\"");
            return valval;
        }

        public static string ReadPascalString(this BinaryReader reader)
        {
            return reader.ReadPascalString(Encoding.UTF8);
        }

        public static string ReadPascalString(this BinaryReader reader, Encoding encoding)
        {
            List<byte> bytes = new List<byte>();
            int count = reader.ReadInt16();
            for (int i = 0; i < count; i++)
                bytes.Add(reader.ReadByte());

            if (count > 0)
                reader.ReadByte();
            else
                return "null";

            return encoding.GetString(bytes.ToArray());
        }

        public static string ReadPositionXYZOStreamer(this BinaryReader reader)
        {
            return "X: " + reader.ReadSingle() + " Y: " + reader.ReadSingle() + "Z: " + reader.ReadSingle() + "O: " + reader.ReadSingle();
        }

        public static string ReadPositionXYZStreamer(this BinaryReader reader)
        {
            return "X: " + reader.ReadSingle() + " Y: " + reader.ReadSingle() + "Z: " + reader.ReadSingle();
        }

        public static BinaryReader Decompress(this BinaryReader gr)
        {
            var uncompressedLength = gr.ReadInt32();
            gr.ReadBytes(2); // unk junk from RFC 1950
            var input = gr.ReadBytes((int)(gr.BaseStream.Length - gr.BaseStream.Position));
            gr.Close();
            var dStream = new DeflateStream(new MemoryStream(input), CompressionMode.Decompress);
            var output = new byte[uncompressedLength];
            dStream.Read(output, 0, output.Length);
            dStream.Close();
            return new BinaryReader(new MemoryStream(output));
        }

        public static T ReadStruct<T>(this BinaryReader reader) where T : struct
        {
            lock (StructHelper<T>.SyncRoot)
            {
                reader.Read(StructHelper<T>.ManagedDataBank, 0, StructHelper<T>.Size);
                Marshal.Copy(StructHelper<T>.ManagedDataBank, 0, StructHelper<T>.UnmanagedDataBank, StructHelper<T>.Size);
                return (T)Marshal.PtrToStructure(StructHelper<T>.UnmanagedDataBank, typeof(T));
            }
        }
    }
}
