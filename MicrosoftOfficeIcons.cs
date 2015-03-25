using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CodingCoder.Drawing
{
    /// <summary>
    /// Contains Microsoft Office icons. This class cannot be inherited.
    /// </summary>
    public static class MicrosoftOfficeIcons
    {
        /// <summary>
        /// Gets a System.Drawing.Icon object that contains the Microsoft Excel icon.
        /// </summary>
        public static Icon Excel
        {
            get { return Properties.Resources.ExcelIcon; }
        }

        /// <summary>
        /// Gets a System.Drawing.Icon object that contains the Microsoft Word icon.
        /// </summary>
        public static Icon Word
        {
            get { return Properties.Resources.WordIcon; }
        }
    }
}
