using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class itemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    void Start()
    {
        items.Add(new Item("apple", 1001, "test", 10, 1, 0, 0, Item.ItemType.other));
        items.Add(new Item("gem", 1001, "test", 10, 1, 0, 0, Item.ItemType.other));
        items.Add(new Item("mp", 1001, "test", 10, 1, 0, 0, Item.ItemType.other));
        items.Add(new Item("hp", 1001, "test", 10, 1, 0, 0, Item.ItemType.other));
        items.Add(new Item("rings", 1001, "test", 10, 1, 0, 0, Item.ItemType.other));
    }

}

