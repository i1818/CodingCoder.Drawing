using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CodingCoder.Drawing
{
    /// <summary>
    /// Each property of the Vesuvius.Drawing.IconSizes class is a System.Drawing.Size structure for commonly used icon and image sizes. This class cannot be inherited.
    /// </summary>
    public static class IconSizes
    {
        /// <summary>
        /// Get a System.Drawing.Size structure that represents a small sized icon (16x16 pixels).
        /// </summary>
        public static Size Small
        {
            get { return new Size(16, 16); }
        }

        /// <summary>
        /// Get a System.Drawing.Size structure that represents a medium sized icon (24x24 pixels).
        /// </summary>
        public static Size Medium
        {
            get { return new Size(24, 24); }
        }

        /// <summary>
        /// Get a System.Drawing.Size structure that represents a large sized icon (32x32 pixels).
        /// </summary>
        public static Size Large
        {
            get { return new Size(32, 32); }
        }
    }
}
