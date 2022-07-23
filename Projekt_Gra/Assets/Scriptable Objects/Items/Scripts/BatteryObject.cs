using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Battery Object", menuName = "Inventory System/Items/Battery")]
public class BatteryObject : ItemObjects
{

    public void Awake()
    {
        type = ItemType.Battery;
    }
}
