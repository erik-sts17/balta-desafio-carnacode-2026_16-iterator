using Iterator.Domain.Enums;

namespace Iterator.Domain.Abstractions
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator(PlayerType? type = null, string? param = null);
    }
}