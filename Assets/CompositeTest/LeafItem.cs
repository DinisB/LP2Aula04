using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LeafItem : AbstractItem
{
    private float weight;

    public LeafItem(float weight)
    {
        this.weight = weight;
    }

    public override float Weight
    {
        get { return weight; }
    }

    public override void Add(AbstractItem item)
    {
        return;
    }

    public override void Remove(AbstractItem item)
    {
        return;
    }

    public override IEnumerator<AbstractItem> GetEnumerator()
    {
        yield break;
    }
}
