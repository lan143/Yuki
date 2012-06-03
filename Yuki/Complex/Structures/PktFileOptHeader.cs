//Copyright (C) 2012 WoW-Mig <http://www.wow-mig.ru/>
//This file is free software; as a special exception the author gives
//unlimited permission to copy and/or distribute it, with or without
//modifications, as long as this notice is preserved.

//This program is distributed in the hope that it will be useful, but
//WITHOUT ANY WARRANTY, to the extent permitted by law; without even the
//implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

namespace Yuki.Complex.Structures
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PktFileOptHeader
    {
        public uint CreatedOnUnix;
        public uint CreatedOnTicks;
        public uint SessionLength;
        public uint PacketCount;
        public uint FirstClientOpcode;
        public uint FirstServerOpcode;
        public string description;
    }
}
