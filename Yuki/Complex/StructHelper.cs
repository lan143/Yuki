//Copyright (C) 2012 WoW-Mig <http://www.wow-mig.ru/>
//This file is free software; as a special exception the author gives
//unlimited permission to copy and/or distribute it, with or without
//modifications, as long as this notice is preserved.

//This program is distributed in the hope that it will be useful, but
//WITHOUT ANY WARRANTY, to the extent permitted by law; without even the
//implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

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
