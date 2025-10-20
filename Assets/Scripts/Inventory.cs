using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public List<string> items = new List<string>();

    public GameManager manager;
    

    public void AddItemToInventory(string itemName)
    {
        items.Add(itemName);
    }

    public void RemoveItemFromInventory(string itemName)
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
        


    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        ItemObject collisionItem = hit.gameObject.GetComponent<ItemObject>();

        if (collisionItem != null)
        {
            items.Add(collisionItem.name);
            Destroy(collisionItem.gameObject);
        }
    }

}
