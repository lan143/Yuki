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
