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
            if (Input.GetMouseButtonDown(1)) 
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
