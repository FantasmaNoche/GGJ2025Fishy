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
            if (Input.GetMouseButtonDown(1)) 
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
