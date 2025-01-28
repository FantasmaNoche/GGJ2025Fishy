using System;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public class Fishy : MonoBehaviour
{
    private FishyCounter fishyCounter;
    public GameObject[] levels;
    public int[] clicksForLevel;
    
    public GameObject FishyBase;


    public int clicks = 10;
    
    
    private int currentLevel = -1;
    private GameObject lvlInstance;
    
    private void Start()
    {
        fishyCounter = GameObject.FindFirstObjectByType<FishyCounter>();
    }

    void Update()
    {
        UpdateLevel();
    }

    private void UpdateLevel()
    {
        int newLevel = 0;
        foreach (int click in clicksForLevel)
        {
            if(fishyCounter.click >= click)
                newLevel = newLevel + 1;
            else
                break;
        }

        
        if (newLevel != currentLevel)
        {
            if(lvlInstance != null)
                Destroy(lvlInstance);

            
            GameObject prefab = levels[newLevel - 1];
            lvlInstance = Instantiate(prefab, transform);
            lvlInstance.transform.localPosition = Vector3.zero;
            currentLevel = newLevel;
        }
        
    }

    
  
}
