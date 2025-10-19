using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class AbstractItem : IHasWeight, IBag<AbstractItem>, IEnumerable<AbstractItem>
{
    public abstract float Weight { get; }

    public abstract void Add(AbstractItem item);
    public abstract void Remove(AbstractItem item);

    public abstract IEnumerator<AbstractItem> GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
