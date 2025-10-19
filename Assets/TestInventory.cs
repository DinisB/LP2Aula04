using UnityEngine;

public class TestInventory : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CompositeItem items = new CompositeItem();

        items.Add(new LeafItem(5));
        items.Add(new LeafItem(8));
        items.Add(new LeafItem(3));

        CompositeItem itemsdois = new CompositeItem();

        itemsdois.Add(new LeafItem(10));
        itemsdois.Add(new LeafItem(4));

        items.Add(itemsdois);

        Debug.Log("Peso: " + items.Weight);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
