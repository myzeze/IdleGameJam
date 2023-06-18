using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantingSystem : MonoBehaviour
{
    public GameObject carrotPrefab;
    public Transform plantingArea;

    private void Update()
    {
        //Getting the button responsible for planting logic, calling prefab
        if (Input.GetButtonDown("Fire1"))
        {
            Plant(carrotPrefab);
        }
    }

    private void Plant(GameObject plantPrefab)
    {
        //instantiate the prefab at the areas position and rotation
        GameObject plant = Instantiate(plantPrefab, plantingArea.position, Quaternion.identity);
        // make list/array

    }
}
