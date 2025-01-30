using System.Collections;
using UnityEngine;

public class FishyLvl1 : MonoBehaviour
{
    private AttackCharge chargeAttack;
    public int minCharge = 0; 
    public int maxCharge = 100; 
    public int charging = 10;
    public int currentCharge;
   
    void Start()
    {
       
        chargeAttack = GameObject.FindFirstObjectByType<AttackCharge>();
        if (chargeAttack == null)
        {
            return;
        }

        
        currentCharge = minCharge;
        chargeAttack.InitializeCharge(minCharge, maxCharge);
        
        StartCoroutine(ChargeCoroutine());
    }

    void Awake()
    {
        PlayTransfo();
    }
    
    public AudioClip audio1;
    private AudioSource _audioSource;
    
    void PlayTransfo()
    {
        GameObject audioObject = new GameObject("TempAudio");
        AudioSource tempAudioSource = audioObject.AddComponent<AudioSource>();
        tempAudioSource.clip = audio1;
        tempAudioSource.priority = 10;
        tempAudioSource.Play();
        Destroy(audioObject, audio1.length);
    }

    IEnumerator ChargeCoroutine()
    {
        yield return new WaitForSeconds(1);
        
        while (charging < maxCharge)
        {
            charging += 10;
            chargeAttack.SetCharge(charging);
            yield return new WaitForSeconds(3);
        }
    }
    
    public class PlayerData : MonoBehaviour
    {
        public float spawnRateMultiplier = 1f; 
    }
}
