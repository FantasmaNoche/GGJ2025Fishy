using UnityEngine;

public class FishyLvl2 : MonoBehaviour
{
    public GameObject FishyLvl3;
    public FishyCounter fishyCounter;
    public GameObject FishyActualLvl;

    void Update()
    {
        if (fishyCounter.click == 20)
        {
            Instantiate(FishyLvl3, transform.position, Quaternion.identity);
        }
        
        if (fishyCounter.click == 15)
        { 
            FishyLvl3.SetActive(true);
            FishyActualLvl.SetActive(false);
        }
    }
}
