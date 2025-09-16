using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common
{
    internal class ChartData
    {
        public ChartData()
        {
            public List<string> Labels { get; } = new List<string>();
            public List<string> XLabels { get; } = new List<string>();
            public List<string> YLabels { get;} = new List<string>();
            public List<Dataset> Datasets { get; } = new List<Dataset>();
        }

    }
}
