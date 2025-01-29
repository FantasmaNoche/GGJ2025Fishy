using UnityEngine;

public class FishyAttackLvl3 : MonoBehaviour
{
    private AttackCharge attackCharged;
    public int currentCharge;
    public FishyLvl3 fishyLvl3;   


    private void Start()
    {
        attackCharged = GameObject.FindFirstObjectByType<AttackCharge>();
        
        fishyLvl3 = GameObject.FindFirstObjectByType<FishyLvl3>();
    }

    void Update()
    {
        if (fishyLvl3 != null && fishyLvl3.charging >= fishyLvl3.maxCharge)
        {
            if (Input.GetKey(KeyCode.Q)) 
            {
                Attack();
                fishyLvl3.charging = 0; 
                attackCharged.SetCharge(fishyLvl3.charging); 
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
