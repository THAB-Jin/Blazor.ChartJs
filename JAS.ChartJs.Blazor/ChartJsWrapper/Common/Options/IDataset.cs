using ChartJsWrapper.Common.Enums;

namespace ChartJsWrapper.Common.Options
{
    public interface IDataset
    {
        string Id { get; }
        ChartType Type { get; }
    }

    public interface IDataset<T> : IDataset, IList<T>
    {
        IReadOnlyList<T> Data { get; }
    }
}
