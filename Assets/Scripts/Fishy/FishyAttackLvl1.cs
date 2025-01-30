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
             if (Input.GetMouseButtonDown(1)) 
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
                PlayAttack();
            Destroy(shrimp);
        }
    }

    public AudioClip audio1;
    private AudioSource _audioSource;
    
    void PlayAttack()
    {
        GameObject audioObject = new GameObject("TempAudio");
        AudioSource tempAudioSource = audioObject.AddComponent<AudioSource>();
        tempAudioSource.clip = audio1;
        tempAudioSource.priority = 15;
        tempAudioSource.Play();
        Destroy(audioObject, audio1.length);
    }

}
