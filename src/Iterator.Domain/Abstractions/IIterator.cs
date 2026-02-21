namespace Iterator.Domain.Abstractions
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
        void Reset();
    }
}