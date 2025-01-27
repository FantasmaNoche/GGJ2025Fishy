using UnityEngine;
using TMPro;

public class FishyCounter : MonoBehaviour
{
    public  TMP_Text clicktext;
    public int click;
    

    public void ClicksCounter()
    {
        click++;
        clicktext.text = "" + click;
    }

  
}

