using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Handlers
{
    public delegate void ChartMouseEvent(JObject mouseEvent, JArray activeElements);
}
