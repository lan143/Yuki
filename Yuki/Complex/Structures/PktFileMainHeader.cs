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
