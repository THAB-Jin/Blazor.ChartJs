using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ChartJsWrapper.Common.Enums;

namespace ChartJsWrapper.Common.Options
{
    public class Animation
    {
        public long? Duration { get; set; }

        public Easing Easing { get; set; }

    }
