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
using Yuki.Complex;

namespace Yuki.WoW.Parsers
{
    class CreatureResponse
    {
        private int entry;
        private string[] name = new string[8];
        private string subname;
        private string IconName;
        private int type_flags;
        private int type_flags2;
        private int type;
        private int family;
        private int rank;
        private int[] KillCredit = new int[2];
        private int[] Modelid = new int[4];
        private float ModHealth;
        private float ModMana;
        private byte RacialLeader;
        private int[] questItems = new int[6];
        private int movementId;
        private int expansionUnknown;

        public CreatureResponse()
        {
            entry = 0;

            for (int i = 0; i < 8; ++i)
                name[i] = null;

            subname = null;
            IconName = null;
            type_flags = 0;
            type_flags2 = 0;
            type = 0;
            family = 0;
            rank = 0;

            for (int i = 0; i < 2; ++i)
                KillCredit[i] = 0;

            for (int i = 0; i < 4; ++i)
                Modelid[i] = 0;

            ModHealth = 0.0f;
            ModMana = 0.0f;
            RacialLeader = 0;

            for (int i = 0; i < 6; ++i)
                questItems[i] = 0;

            movementId = 0;
            expansionUnknown = 0;
        }

        public CreatureResponse(BinaryReader br)
        {
            entry = br.ReadInt32();

            for (int i = 0; i < 8; ++i)
                name[i] = br.ReadCString();

            subname = br.ReadCString();
            IconName = br.ReadCString();
            type_flags = br.ReadInt32();
            type_flags2 = br.ReadInt32();
            type = br.ReadInt32();
            family = br.ReadInt32();
            rank = br.ReadInt32();

            for (int i = 0; i < 2; ++i)
                KillCredit[i] = br.ReadInt32();

            for (int i = 0; i < 4; ++i)
                Modelid[i] = br.ReadInt32();

            ModHealth = br.ReadSingle();
            ModMana = br.ReadSingle();
            RacialLeader = br.ReadByte();

            for (int i = 0; i < 6; ++i)
                questItems[i] = br.ReadInt32();

            movementId = br.ReadInt32();
            expansionUnknown = br.ReadInt32();
        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder(100, 12000);

            sb.AppendFormatLine("Parsing info of creature.");
            sb.AppendFormatLine("Entry: {0}", entry);

            for (int i = 0; i < 8; ++i)
                sb.AppendFormatLine("Name[{0}]: {1}", i, name[i]);

            sb.AppendFormatLine("Sub Name:      {0}", subname);
            sb.AppendFormatLine("Icon Name:     {0}", IconName);
            sb.AppendFormatLine("Type flags:    {0}", type_flags);
            sb.AppendFormatLine("Type flags 2:  {0}", type_flags2);
            sb.AppendFormatLine("Type:          {0}", type);
            sb.AppendFormatLine("Family:        {0}", family);
            sb.AppendFormatLine("Rank:          {0}", rank);

            for (int i = 0; i < 2; ++i)
                sb.AppendFormatLine("Kill Credit {0}: {1}", i, KillCredit[i]);

            for (int i = 0; i < 4; ++i)
                sb.AppendFormatLine("Model id {0}: {1}", i, Modelid[i]);

            sb.AppendFormatLine("Mod Health:    {0}", ModHealth);
            sb.AppendFormatLine("Mod Mana:      {0}", ModMana);
            sb.AppendFormatLine("Racial Leader: {0}", RacialLeader);

            for (int i = 0; i < 6; ++i)
                sb.AppendFormatLine("Quest Items {0}: {1}", i, questItems[i]);

            sb.AppendFormatLine("Movement Id:   {0}", movementId);
            sb.AppendFormatLine("Expansion Unk: {0}", expansionUnknown);

            return sb.ToString();
        }

        public string ToSQL()
        {
            StringBuilder sb = new StringBuilder(100, 12000);

            return sb.ToString();
        }
    }
}
