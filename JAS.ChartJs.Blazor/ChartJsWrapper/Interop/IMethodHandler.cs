using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Interop
{
    public interface IMethodHandler<T> : IMethodHandler
        where T : Delegate
    {
    }

    [Obsolete("Use " + nameof(IMethodHandler) + "<T> instead.")]
    public interface IMethodHandler
    {
        public string MethodName { get; }
    }
}
