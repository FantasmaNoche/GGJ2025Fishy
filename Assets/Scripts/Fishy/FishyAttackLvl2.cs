using UnityEngine;

public class FishyAttackLvl2 : MonoBehaviour
{
    private AttackCharge attackCharged;
    public int currentCharge;
    public FishyLvl2 fishyLvl2;   


    private void Start()
    {
        attackCharged = GameObject.FindFirstObjectByType<AttackCharge>();
        
        fishyLvl2 = GameObject.FindFirstObjectByType<FishyLvl2>();
    }

    void Update()
    {
        if (fishyLvl2 != null && fishyLvl2.charging >= fishyLvl2.maxCharge)
        {
            if (Input.GetMouseButtonDown(1)) 
            {
                Attack();
                fishyLvl2.charging = 0; 
                attackCharged.SetCharge(fishyLvl2.charging); 
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