namespace Structure.Interfaces
{
    public interface ILinkedList<T>
    {

        void Append(T value);

        void RemoveAt(int index);

        T GetAt(int index);
         
    }
}