using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{

    public List<string> items = new List<string>();
    public string itemName = string.Empty;

    public GameManager manager;
    

    public void AddItemToInventory(string ItemName)
    {
        items.Add(itemName);
    }

    public void RemoveItemFromInventory(string ItemName)
    {
        items.Remove(itemName);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            AddItemToInventory("Generic Item");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            RemoveItemFromInventory("Generic Item");
        }
    }
}
