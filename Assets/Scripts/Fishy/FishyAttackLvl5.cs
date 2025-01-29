using UnityEngine;

public class FishyAttackLvl5 : MonoBehaviour
{
    private AttackCharge attackCharged;
    public int currentCharge;
    public FishyLvl5 fishyLvl5;   


    private void Start()
    {
        attackCharged = GameObject.FindFirstObjectByType<AttackCharge>();
        
        fishyLvl5 = GameObject.FindFirstObjectByType<FishyLvl5>();
    }

    void Update()
    {
        if (fishyLvl5 != null && fishyLvl5.charging >= fishyLvl5.maxCharge)
        {
            if (Input.GetMouseButtonDown(1)) 
            {
                Attack();
                fishyLvl5.charging = 0; 
                attackCharged.SetCharge(fishyLvl5.charging); 
            }
        }
    }
    
    private void Attack()
    {
        GameObject[] shrimps = GameObject.FindGameObjectsWithTag("Shrimp");
        foreach (GameObject shrimp in shrimps)
        {
            Destroy(shrimp);
        }
    }

}
