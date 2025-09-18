using ChartJsWrapper.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common
{
    public interface IDataset
    {
        string datasetId { get; }
        ChartType Type { get; }
    }

    public interface IDataset<T> : IDataset, IList<T>
    {
        /// <summary>
        /// Gets the data contained in this dataset. This property is read-only.
        /// This is in addition to implementing <see cref="IList{T}"/>.
        /// </summary>
        IReadOnlyList<T> Data { get; }
    }
}
