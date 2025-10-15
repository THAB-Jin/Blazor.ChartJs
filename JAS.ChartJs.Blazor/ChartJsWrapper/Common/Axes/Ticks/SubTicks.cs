using ChartJsWrapper.Common.Enums;
using ChartJsWrapper.Common;

namespace ChartJsWrapper.Common.Axes.Ticks
{
    // The ultimate base class for tick mark configurations.
    public abstract class SubTicks
    {
        public Font TickFont { get; set; }
        public double? LineHeight { get; set; }


        //Potentially deprecated in newer versions??
        /// <summary>
        /// Gets or sets the font color for a tick's label.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        //public string FontColor { get; set; }

        /// <summary>
        /// Gets or sets the font family for a tick's label.
        /// </summary>
        //public string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the font size for a tick's label.
        /// </summary>
        //public int? FontSize { get; set; }

        /// <summary>
        /// Gets or sets the font style for a tick's label.
        /// </summary>
        //public FontStyle FontStyle { get; set; }

        /// <summary>
        /// Gets or sets the height of an individual line of text.
        /// <para>As per documentation <a href="https://developer.mozilla.org/en-US/docs/Web/CSS/line-height">here (MDN)</a>.</para>
        /// </summary>
    }
}
