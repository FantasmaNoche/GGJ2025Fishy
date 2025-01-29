using UnityEngine;

public class FishyAttackLvl4 : MonoBehaviour
{
    private AttackCharge attackCharged;
    public int currentCharge;
    public FishyLvl4 fishyLvl4;   


    private void Start()
    {
        attackCharged = GameObject.FindFirstObjectByType<AttackCharge>();
        
        fishyLvl4 = GameObject.FindFirstObjectByType<FishyLvl4>();
    }

    void Update()
    {
        if (fishyLvl4 != null && fishyLvl4.charging >= fishyLvl4.maxCharge)
        {
            if (Input.GetKey(KeyCode.Q)) 
            {
                Attack();
                fishyLvl4.charging = 0; 
                attackCharged.SetCharge(fishyLvl4.charging); 
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
