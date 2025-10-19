using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CompositeItem : AbstractItem
{
    private List<AbstractItem> items = new List<AbstractItem>();

    public override float Weight
    {
        get
        {
            float total = 0;
            foreach (AbstractItem item in items)
            {
                total += item.Weight;
            }
            return total;
        }
    }

    public override void Add(AbstractItem item) => items.Add(item);

    public override void Remove(AbstractItem item) => items.Remove(item);

    public override IEnumerator<AbstractItem> GetEnumerator()
    {
        return items.GetEnumerator();
    }
}
