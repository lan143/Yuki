using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Yuki.Complex;
using Yuki.Complex.Enums;

namespace Yuki.ConditionGenerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            for (int i = 0; i < (int)eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_MAX; ++i)
                cbSourceTypeOrReferenceId.Items.Add(Enum.GetName(typeof(eSourceTypeOrReferenceId), (eSourceTypeOrReferenceId)i));

            for (int i = 0; i < (int)eConditionTypeOrReference.CONDITION_MAX; ++i)
                cbConditionTypeOrReference.Items.Add(Enum.GetName(typeof(eConditionTypeOrReference), (eConditionTypeOrReference)i));
        }

        private void ResetSource()
        {
            lSourceGroup.Text = "SourceGroup:";
            lSourceEntry.Text = "SourceEntry";
            lConditionTarget.Text = "ConditionTarget:";
        }

        private void cbSourceTypeOrReferenceId_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetSource();

            switch ((eSourceTypeOrReferenceId)cbSourceTypeOrReferenceId.SelectedIndex)
            {
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_CREATURE_LOOT_TEMPLATE:
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_DISENCHANT_LOOT_TEMPLATE:
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_FISHING_LOOT_TEMPLATE:
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_GAMEOBJECT_LOOT_TEMPLATE:
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_ITEM_LOOT_TEMPLATE:
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_MAIL_LOOT_TEMPLATE:
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_MILLING_LOOT_TEMPLATE:
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_PICKPOCKETING_LOOT_TEMPLATE:
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_PROSPECTING_LOOT_TEMPLATE:
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_REFERENCE_LOOT_TEMPLATE:
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_SKINNING_LOOT_TEMPLATE:
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_SPELL_LOOT_TEMPLATE:
                    lSourceGroup.Text = "loot entry:";
                    lSourceEntry.Text = "*_loot_template.Item";
                    lConditionTarget.Text =  "ConditionTarget:";
                    break;
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_SPELL_IMPLICIT_TARGET:
                    lSourceGroup.Text = "Mask of effects:";
                    lSourceEntry.Text = "Spell Id:";
                    break;
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_GOSSIP_MENU:
                    lSourceGroup.Text = "Gossip menu entry:";
                    lSourceEntry.Text = "Gossip menu text id:";
                    break;
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_GOSSIP_MENU_OPTION:
                    lSourceGroup.Text = "Gossip menu entry:";
                    lSourceEntry.Text = "Gossip menu option id:";
                    break;
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_CREATURE_TEMPLATE_VEHICLE:
                    lSourceGroup.Text = "SourceGroup:";
                    lSourceEntry.Text = "Creature entry:";
                    break;
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_SPELL:
                    lSourceGroup.Text = "SourceGroup:";
                    lSourceEntry.Text = "Spell Id:";
                    break;
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_SPELL_CLICK_EVENT:
                    lSourceGroup.Text = "Creature entry:";
                    lSourceEntry.Text = "Spell Id:";
                    break;
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_QUEST_ACCEPT:
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_QUEST_SHOW_MARK:
                    lSourceEntry.Text = "Quest Id:";
                    break;
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_VEHICLE_SPELL:
                    lSourceGroup.Text = "Creature entry:";
                    lSourceEntry.Text = "Spell Id:";
                    break;
                case eSourceTypeOrReferenceId.CONDITION_SOURCE_TYPE_SMART_EVENT:
                    lSourceGroup.Text = "Smart script Id:";
                    lSourceEntry.Text = "Smart script EntryOrGUID:";
                    lSourceId.Text = "Smart script source type:";
                    break;
            }
        }

        private void ResetValues()
        {
            lConditionValue1.Text = "ConditionValue1:";
            lConditionValue2.Text = "ConditionValue2:";
            lConditionValue3.Text = "ConditionValue3:";
        }

        private void cbConditionTypeOrReference_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetValues();

            switch ((eConditionTypeOrReference)cbConditionTypeOrReference.SelectedIndex)
            {
                case eConditionTypeOrReference.CONDITION_AURA:
                    lConditionValue1.Text = "Spell Id:";
                    lConditionValue2.Text = "Spell effect:";
                    break;
                case eConditionTypeOrReference.CONDITION_ITEM:
                    lConditionValue1.Text = "Item entry:";
                    lConditionValue2.Text = "Item count:";
                    lConditionValue3.Text = "In bank:";
                    break;
                case eConditionTypeOrReference.CONDITION_ITEM_EQUIPPED:
                    lConditionValue1.Text = "Item entry:";
                    break;
                case eConditionTypeOrReference.CONDITION_ZONEID:
                    lConditionValue1.Text = "Zone Id:";
                    break;
                case eConditionTypeOrReference.CONDITION_REPUTATION_RANK:
                    lConditionValue1.Text = "Faction Id:";
                    lConditionValue2.Text = "Rank:";
                    break;
                case eConditionTypeOrReference.CONDITION_TEAM:
                    lConditionValue1.Text = "Team Id:";
                    break;
                case eConditionTypeOrReference.CONDITION_SKILL:
                    lConditionValue1.Text = "Skill Id:";
                    lConditionValue2.Text = "Skill value:";
                    break;
                case eConditionTypeOrReference.CONDITION_QUESTREWARDED:
                case eConditionTypeOrReference.CONDITION_QUESTTAKEN:
                case eConditionTypeOrReference.CONDITION_QUEST_NONE:
                case eConditionTypeOrReference.CONDITION_QUEST_COMPLETE:
                    lConditionValue1.Text = "Quest Id:";
                    break;
                case eConditionTypeOrReference.CONDITION_DRUNKENSTATE:
                    lConditionValue1.Text = "Drunken state:";
                    break;
                case eConditionTypeOrReference.CONDITION_WORLD_STATE:
                    lConditionValue1.Text = "World state index:";
                    lConditionValue2.Text = "World state value:";
                    break;
                case eConditionTypeOrReference.CONDITION_ACTIVE_EVENT:
                    lConditionValue1.Text = "Game event entry:";
                    break;
                case eConditionTypeOrReference.CONDITION_INSTANCE_DATA:
                    lConditionValue1.Text = "Entry";
                    lConditionValue2.Text = "Data:";
                    break;
                case eConditionTypeOrReference.CONDITION_CLASS:
                    lConditionValue1.Text = "Class Id:";
                    break;
                case eConditionTypeOrReference.CONDITION_RACE:
                    lConditionValue1.Text = "Race:";
                    break;
                case eConditionTypeOrReference.CONDITION_ACHIEVEMENT:
                    lConditionValue1.Text = "Achievement Id:";
                    break;
                case eConditionTypeOrReference.CONDITION_MAPID:
                    lConditionValue1.Text = "Map Id:";
                    break;
                case eConditionTypeOrReference.CONDITION_AREAID:
                    lConditionValue1.Text = "Area Id:";
                    break;
                case eConditionTypeOrReference.CONDITION_SPELL:
                    lConditionValue1.Text = "Spell Id:";
                    break;
                case eConditionTypeOrReference.CONDITION_PHASEMASK:
                    lConditionValue1.Text = "Phase mask:";
                    break;
                case eConditionTypeOrReference.CONDITION_LEVEL:
                    lConditionValue1.Text = "Player level:";
                    lConditionValue2.Text = "Option:";
                    break;
                case eConditionTypeOrReference.CONDITION_NEAR_CREATURE:
                case eConditionTypeOrReference.CONDITION_NEAR_GAMEOBJECT:
                    lConditionValue1.Text = "Entry:";
                    lConditionValue2.Text = "Distance:";
                    break;
                case eConditionTypeOrReference.CONDITION_OBJECT_ENTRY:
                    lConditionValue1.Text = "TypeID:";
                    lConditionValue2.Text = "Entry:";
                    break;
                case eConditionTypeOrReference.CONDITION_TYPE_MASK:
                    lConditionValue1.Text = "TypeMask:";
                    break;
                case eConditionTypeOrReference.CONDITION_RELATION_TO:
                    lConditionValue1.Text = "Target:";
                    lConditionValue2.Text = "RelationType:";
                    break;
                case eConditionTypeOrReference.CONDITION_REACTION_TO:
                    lConditionValue1.Text = "Target";
                    lConditionValue2.Text = "Rank Mask:";
                    break;
                case eConditionTypeOrReference.CONDITION_DISTANCE_TO:
                    lConditionValue1.Text = "Target:";
                    lConditionValue2.Text = "Distance:";
                    lConditionValue3.Text = "Comparision Type:";
                    break;
                case eConditionTypeOrReference.CONDITION_HP_VAL:
                    lConditionValue1.Text = "Hp:";
                    lConditionValue2.Text = "Comparision Type:";
                    break;
                case eConditionTypeOrReference.CONDITION_HP_PCT:
                    lConditionValue1.Text = "Percentage of max HP:";
                    lConditionValue2.Text = " Comparision Type:";
                    break;
            }
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            Output.AppendFormatLine("DELETE FROM `conditions` WHERE `SourceEntry` = {0};", Int32.Parse(tbSourceEntry.Text));
            Output.AppendLine("INSERT INTO `conditions` (`SourceTypeOrReferenceId`, `SourceGroup`, `SourceEntry`, `SourceId`, `ElseGroup`, `ConditionTypeOrReference`, `ConditionValue1`, `ConditionValue2`, `ConditionValue3`, `ErrorTextId`, `ScriptName`, `Comment`)");
            Output.AppendLine("VALUES");
            Output.AppendFormatLine("({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, '{10}', '{11}');", cbSourceTypeOrReferenceId.SelectedIndex, Int32.Parse(tbSourceGroup.Text), Int32.Parse(tbSourceEntry.Text), Int32.Parse(tbSourceId.Text), Int32.Parse(tbElseGroup.Text), cbConditionTypeOrReference.SelectedIndex, Int32.Parse(tbConditionValue1.Text), Int32.Parse(tbConditionValue2.Text), Int32.Parse(tbConditionValue3.Text), Int32.Parse(tbErrorTextId.Text), tbScriptName.Text, tbComment.Text);
            Output.AppendLine();
            Output.ColorizeCode();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(saveFileDialog1.FileName, FileMode.Create), Encoding.UTF8))
                {
                    sw.WriteLine("-- Dump of {0:yyyy.MM.dd HH:mm:ss}" + Environment.NewLine, DateTime.Now);
                    sw.Write(Output.Text);
                    sw.Flush();
                }
            }
        }
    }
}

