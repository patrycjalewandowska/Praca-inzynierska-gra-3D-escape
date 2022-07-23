using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Flashlight Object", menuName = "Inventory System/Items/Flashlight")]
public class FlashlightObject : ItemObjects
{
    public void Awake()
    {

        type = ItemType.Flashlight;
    }
}
