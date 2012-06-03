//Copyright (C) 2012 WoW-Mig <http://www.wow-mig.ru/>
//This file is free software; as a special exception the author gives
//unlimited permission to copy and/or distribute it, with or without
//modifications, as long as this notice is preserved.

//This program is distributed in the hope that it will be useful, but
//WITHOUT ANY WARRANTY, to the extent permitted by law; without even the
//implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Drawing;

namespace Yuki.Complex
{
    public static class RichTextBoxExtensions
    {
        public const string DEFAULT_FAMILY = "Arial Unicode MS";
        public const float DEFAULT_SIZE = 9f;

        public static void Append(this RichTextBox textbox, object text)
        {
            textbox.AppendText(text.ToString());
        }

        public static void AppendFormat(this RichTextBox textbox, string format, params object[] arg0)
        {
            textbox.AppendText(string.Format(CultureInfo.InvariantCulture, format, arg0));
        }

        public static void AppendFormatIfNotNull(this RichTextBox builder, string format, float arg)
        {
            if (arg != 0f)
            {
                builder.AppendFormat(format, new object[] { arg });
            }
        }

        public static void AppendFormatIfNotNull(this RichTextBox builder, string format, uint arg)
        {
            if (arg != 0)
            {
                builder.AppendFormat(format, new object[] { arg });
            }
        }

        public static void AppendFormatLine(this RichTextBox textbox, string format, params object[] arg0)
        {
            textbox.AppendText(string.Format(CultureInfo.InvariantCulture, format, arg0) + Environment.NewLine);
        }

        public static void AppendFormatLineIfNotNull(this RichTextBox builder, string format, float arg)
        {
            if (arg != 0f)
            {
                builder.AppendFormatLine(format, new object[] { arg });
            }
        }

        public static void AppendFormatLineIfNotNull(this RichTextBox builder, string format, string arg)
        {
            if (arg != string.Empty)
            {
                builder.AppendFormatLine(format, new object[] { arg });
            }
        }

        public static void AppendFormatLineIfNotNull(this RichTextBox builder, string format, uint arg)
        {
            if (arg != 0)
            {
                builder.AppendFormatLine(format, new object[] { arg });
            }
        }

        public static void AppendLine(this RichTextBox textbox)
        {
            textbox.AppendText(Environment.NewLine);
        }

        public static void AppendLine(this RichTextBox textbox, string text)
        {
            textbox.AppendText(text + Environment.NewLine);
        }

        public static void ColorizeCode(this RichTextBox rtb)
        {
            string[] strArray = new string[] { "INSERT", "INTO", "DELETE", "FROM", "IN", "VALUES", "WHERE" };
            string text = rtb.Text;
            rtb.SelectAll();
            rtb.SelectionColor = rtb.ForeColor;
            foreach (string str2 in strArray)
            {
                for (int i = rtb.Find(str2, RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord); i != -1; i = rtb.Find(str2, i + rtb.SelectionLength, RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord))
                {
                    int num2 = text.LastIndexOf("-- ", i, StringComparison.OrdinalIgnoreCase);
                    int num3 = text.LastIndexOf("\n", i, StringComparison.OrdinalIgnoreCase);
                    int num4 = 0;
                    int num5 = text.IndexOf("\"", num3 + 1, i - num3, StringComparison.OrdinalIgnoreCase);
                    while (num5 != -1)
                    {
                        num5 = text.IndexOf("\"", num5 + 1, i - (num5 + 1), StringComparison.OrdinalIgnoreCase);
                        num4++;
                    }
                    if ((num3 >= num2) && ((num4 % 2) == 0))
                    {
                        rtb.SelectionColor = Color.Blue;
                    }
                    else if (num3 == num2)
                    {
                        rtb.SelectionColor = Color.Green;
                    }
                }
            }
            rtb.Select(0, 0);
        }

        public static void SetBold(this RichTextBox textbox)
        {
            textbox.SelectionFont = new Font("Arial Unicode MS", 9f, FontStyle.Bold);
        }

        public static void SetDefaultStyle(this RichTextBox textbox)
        {
            textbox.SelectionFont = new Font("Arial Unicode MS", 9f, FontStyle.Regular);
            textbox.SelectionColor = Color.Black;
        }

        public static void SetStyle(this RichTextBox textbox, Color color, FontStyle style)
        {
            textbox.SelectionColor = color;
            textbox.SelectionFont = new Font("Arial Unicode MS", 9f, style);
        }
    }
}
