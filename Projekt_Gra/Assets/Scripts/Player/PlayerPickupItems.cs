using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickupItems : MonoBehaviour

{
    public InventoryObject inventory;
    bool test;

    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<GroundItem>();

        if (item)
        {
            inventory.AddItem(new Item(item.item), 1);
            Destroy(other.gameObject);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("ZAPIS");
            inventory.Save();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("POBRANO DANE");
            inventory.Load();
        }

        for (int i = 0; i < inventory.Container.Items.Length; i++)
        {
           // Debug.Log(inventory.Container.Items[i].ID);
            if (inventory.Container.Items[i].ID == -1)
            {
                test = true;
            }
            else
            {
                test = false;
            }

        }
    }
    private void OnApplicationQuit()
    {
        inventory.Container.Items = new InventorySlot[16];
    }
}

