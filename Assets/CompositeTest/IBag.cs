using UnityEngine;

public interface IBag<T>
{
    public void Add(T item);
    public void Remove(T item);
}
