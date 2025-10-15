using ChartJsWrapper.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common
{
    /// <summary>
    /// Represents a dataset with an id and a type.
    /// </summary>
    public interface IDataset
    {
        string datasetId { get; }
        ChartType Type { get; }
    }

    /// <summary>
    /// Represents a strongly typed dataset that holds data of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of data this dataset contains.</typeparam>
    public interface IDataset<T> : IDataset, IList<T>
    {
        /// <summary>
        /// Gets the data contained in this dataset. This property is read-only.
        /// This is in addition to implementing <see cref="IList{T}"/>.
        /// </summary>
        IReadOnlyList<T> Data { get; }
    }
}
