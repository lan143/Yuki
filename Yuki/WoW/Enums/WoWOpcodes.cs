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

namespace Yuki.WoW.Enums
{
    public enum WoWOpcodes : uint
    {
        SMSG_NEW_WORLD = 25772,
        CMSG_CREATURE_QUERY = 24224,
        SMSG_INIT_WORLD_STATES = 16000,
    }
}
