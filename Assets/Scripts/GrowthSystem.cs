using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthSystem : MonoBehaviour
{
    [Header("Plant settings")]
    // Time in seconds for each growth stage
    public float growthTime = 60f; 
    public GameObject fullyGrownPlantPrefab;

    private float elapsedTime;
    // Initial growth stage
    private int growthStage = 0; 

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= growthTime)
        {
            elapsedTime = 0f;
            IncrementGrowthStage();
        }
    }

    private void IncrementGrowthStage()
    {
        // Check if the growthStage is at the final stage
        if (growthStage >= fullyGrownPlantPrefab.transform.childCount)
        {
            // Plant is fully grown, do something (e.g., remove old plant and spawn rewards)
            return;
        }

        // increment growthStage
        growthStage++;

        // enable the child GO at the corresponding stage index
        for (int i = 0; i < fullyGrownPlantPrefab.transform.childCount; i++)
        {
            fullyGrownPlantPrefab.transform.GetChild(i).gameObject.SetActive(i == growthStage);
        }
    }
}
