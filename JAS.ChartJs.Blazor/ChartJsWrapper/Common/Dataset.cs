using ChartJsWrapper.Common.Enums;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Text;

namespace ChartJsWrapper.Common
{
    /// <summary>
    /// Represents a dataset containing a collection of values.
    /// </summary>
    /// <typeparam name="T">The type of data this <see cref="Dataset{T}"/> contains.</typeparam>
    [JsonObject]
    public abstract class Dataset<T> : Collection<T>, IDataset<T>
    {
        public string datasetId { get; }
        public ChartType Type { get; }
        public IReadOnlyList<T> Data { get; }

        /// <summary>
        /// Creates a new <see cref="Dataset{T}"/>.
        /// </summary>
        /// <param name="type">The <see cref="ChartType"/> this dataset is for.</param>
        /// <param name="id">The id for this dataset. If <see langword="null"/>,
        /// a random GUID string will be used.</param>
        protected Dataset(ChartType type, string id = null) : base(new List<T>())
        {
            Data = new ReadOnlyCollection<T>(Items);
            datasetId = id ?? Guid.NewGuid().ToString();
            Type = type;
        }

        //Extends Collection<T> with a bulk-add method (AddRange), since Collection<T> only has Add() one item at a time.
        public void AddRange(IEnumerable<T> items) => ((List<T>)Items).AddRange(items ?? throw new ArgumentNullException(nameof(items)));

        /// <summary>
        /// Adds the elements of the specified collection to the end of the <see cref="Dataset{T}"/>.
        /// </summary>
        /// <param name="items">
        /// The collection whose elements should be added to the end of the <see cref="Dataset{T}"/>.
        /// </param>
        public void AddRange(params T[] items) => AddRange(items as IEnumerable<T>);

        // Determines whether the specified object is considered equal to the current object.
        public override bool Equals(object obj) => obj is Dataset<T> set &&
        datasetId == set.datasetId &&
                EqualityComparer<IList<T>>.Default.Equals(Items, set.Items);

        public override int GetHashCode() => HashCode.Combine(Items, datasetId);

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static bool operator ==(Dataset<T> left, Dataset<T> right) =>
                EqualityComparer<Dataset<T>>.Default.Equals(left, right);

        public static bool operator !=(Dataset<T> left, Dataset<T> right) => !(left == right);


        //Example usage:
        //public class BarDataset : Dataset<double>
        //{
        //    public BarDataset() : base(ChartType.Bar) { }
        //}

        //var barData = new BarDataset();
        //barData.AddRange(10, 20, 30);   // adds numbers
        //Console.WriteLine(barData.Type); // "bar"
        //Console.WriteLine(barData.Id);   // some GUID


    }
}
