using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    private List<GameObject> collectedItems = new List<GameObject>();

    public void AddItem(GameObject item)
    {
        collectedItems.Add(item);
    }
}
