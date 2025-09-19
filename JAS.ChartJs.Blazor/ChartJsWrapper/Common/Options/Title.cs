using ChartJsWrapper.Common.Enums;

namespace ChartJsWrapper.Common.Options
{
    public class Title
    {
        //Alignment of the title
        public Alignments Align { get; set; }

        //Indicates whether the title is shown or not
        public bool? Display { get; set; }

        //Marks that this box should take the full width/height of the canvas. 
        //If false, the box is sized and placed above/beside the chart area.
        public bool? FullSize { get; set; }

        //Gets or sets teh position of the title
        public Positions Position { get; set; }

        //Font options
        public Font Font { get; set; }

        //Padding options
        //Padding can be supplied in a couple of different formats: https://www.chartjs.org/docs/latest/general/padding.html
        //For now we are just using sinple int
        public int? Padding { get; set; }

        public IndexableOptions<string> Text { get; set; }
    }
}
