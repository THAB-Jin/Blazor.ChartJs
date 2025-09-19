using ChartJsWrapper.Common.Enums;

namespace ChartJsWrapper.Common.Options
{
    public class Font
    {
        public string Family { get; set; }
        public int? Size { get; set; }
        public string Style { get; set; }
        public Weights Weight { get; set; }
        //https://developer.mozilla.org/en-US/docs/Web/CSS/line-height
        //These are all the lineHeight presets, not sure what to use, we'll try strings for now
        public string LineHeight { get; set; } 

    }
}
