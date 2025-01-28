using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class FishyAttackLvl1 : MonoBehaviour
{
    private AttackCharge attackCharged;
    public int currentCharge;
    public FishyLvl1 fishyLvl1;   


    private void Start()
    {
        attackCharged = GameObject.FindFirstObjectByType<AttackCharge>();
        
        fishyLvl1 = GameObject.FindFirstObjectByType<FishyLvl1>();
    }

    void Update()
    {
        if (fishyLvl1 != null && fishyLvl1.charging >= fishyLvl1.maxCharge)
        {
             if (Input.GetKey(KeyCode.Q)) 
             {
                 Attack();
                 fishyLvl1.charging = 0; 
                 attackCharged.SetCharge(fishyLvl1.charging); 
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
