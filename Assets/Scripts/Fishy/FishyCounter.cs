using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class FishyCounter : MonoBehaviour
{
    public  TMP_Text clickText;
    public int click;

  
    public void ClicksCounter()
    {
       click++;
       UpdateClickText();
    }

    IEnumerator CountCoroutine()
    {
        while (true)
        {
        click++;
        UpdateClickText();
        yield return new WaitForSeconds(2f);
        }
    }
    
    private void Start()
    {
        if (clickText == null)
        {
            clickText = GameObject.FindObjectOfType<TMP_Text>();
        }

        
        click = 0;
        UpdateClickText();
        
        StartCoroutine(CountCoroutine());
    }
    
    private void UpdateClickText()
    {
        clickText.text = click.ToString();
    }

    public void ApplyDamage(int percentage)
    {
        click = Mathf.FloorToInt(click * (1 - percentage / 100f)); 
        UpdateClickText();
    }
}

