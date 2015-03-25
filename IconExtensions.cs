using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CodingCoder.Drawing
{
    /// <summary>
    /// Defines the extension methods to the System.Drawing.Icon class. This is a static class.
    /// </summary>
    public static class IconExtensions
    {
        /// <summary>
        /// Returns the icon as a System.Drawing.Image of the specified size.
        /// </summary>
        /// <param name="icon">The System.Drawing.Icon, which acts as the instance for this extension method.</param>
        /// <param name="size">The size (in pixels) of the image to return.</param>
        /// <returns>A value containing an image representation of the icon.</returns>
        public static Image GetImage(this Icon icon, Size size)
        {
            return new Icon(icon, size).ToBitmap();
        }

        /// <summary>
        /// Returns the icon as a 16x16 pixel System.Drawing.Image.
        /// </summary>
        /// <param name="icon">The System.Drawing.Icon, which acts as the instance for this extension method.</param>
        /// <returns>A value containing a 16x16 pixel representation of the icon.</returns>
        public static Image GetSmallImage(this Icon icon)
        {
            return GetImage(icon, IconSizes.Small);
        }

        /// <summary>
        /// Returns the icon as a 24x24 pixel System.Drawing.Image.
        /// </summary>
        /// <param name="icon">The System.Drawing.Icon, which acts as the instance for this extension method.</param>
        /// <returns>A value containing a 24x24 pixel representation of the icon.</returns>
        public static Image GetMediumImage(this Icon icon)
        {
            return GetImage(icon, IconSizes.Medium);
        }

        /// <summary>
        /// Returns the icon as a 32x32 pixel System.Drawing.Image.
        /// </summary>
        /// <param name="icon">The System.Drawing.Icon, which acts as the instance for this extension method.</param>
        /// <returns>A value containing a 32x32 pixel representation of the icon.</returns>
        public static Image GetLargeImage(this Icon icon)
        {
            return GetImage(icon, IconSizes.Large);
        }
    }
}
