//Copyright (C) 2012 WoW-Mig <http://www.wow-mig.ru/>
//This file is free software; as a special exception the author gives
//unlimited permission to copy and/or distribute it, with or without
//modifications, as long as this notice is preserved.

//This program is distributed in the hope that it will be useful, but
//WITHOUT ANY WARRANTY, to the extent permitted by law; without even the
//implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

namespace Yuki.Complex.Structures
{
    using System.Runtime.InteropServices;
    using Yuki.Complex.Enums;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PktFileMainHeader
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public char[] Signature;
        public byte MinorVersion;
        public byte MajorVersion;
        public PktSnifferId SnifferId;
        public uint ClientBuild;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Lang;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public byte[] SessionKey;
        public uint unixTime;
        public uint tickCount;
        public uint OptionalHeaderLength;
    }
}
