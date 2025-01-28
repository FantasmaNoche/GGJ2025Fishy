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
            fishyCounter.ApplyDamage(10);
        }
    }
        
    
    
}
