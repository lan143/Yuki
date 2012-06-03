using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Yuki.Complex
{
    internal static class StructHelper<T> where T : struct
    {
        public static int Size { get; private set; }
        public static IntPtr UnmanagedDataBank { get; private set; }
        public static byte[] ManagedDataBank { get; private set; }
        public static object SyncRoot { get; private set; }

        static StructHelper()
        {
            Size = Marshal.SizeOf(typeof(T));
            UnmanagedDataBank = Marshal.AllocHGlobal(Size);
            ManagedDataBank = new byte[Size];
            SyncRoot = new object();
        }
    }
}
