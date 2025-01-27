using UnityEngine;
using TMPro;
public class Fishy : MonoBehaviour
{
    public FishyCounter fishyCounter;
    public GameObject FishyLvl2;
    public GameObject FishyBase;
    void Update()
    {
        
        if (fishyCounter.click == 10)
            { 
                Destroy(gameObject);
                Instantiate(FishyLvl2, transform.position, Quaternion.identity);
            }
        if (fishyCounter.click == 5)
        { 
            FishyLvl2.SetActive(true);
            FishyBase.SetActive(false);
        }
        
       
      
        
        
    }
}
