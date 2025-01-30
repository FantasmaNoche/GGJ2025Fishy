using UnityEngine;
using TMPro;
public class FishyDamage : MonoBehaviour
{
    private  TMP_Text clickText;
    public int click;
   private FishyCounter fishyCounter;
   public int currentclick;
    private void Start()
    {
        fishyCounter = FindObjectOfType<FishyCounter>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ShrimpBubbles"))
        {
            PlayDamage();
            fishyCounter.ApplyDamage(10);
        }
    }
    public AudioClip audio1;
    private AudioSource _audioSource;
    
    void PlayDamage()
    {
        GameObject audioObject = new GameObject("TempAudio");
        AudioSource tempAudioSource = audioObject.AddComponent<AudioSource>();
        tempAudioSource.clip = audio1;
        tempAudioSource.Play();
        Destroy(audioObject, audio1.length);
    }
        
    
    
}
