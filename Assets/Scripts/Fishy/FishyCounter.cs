using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

public class FishyCounter : MonoBehaviour
{
    public  TMP_Text clickText;
    public int click;

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
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            ClicksCounter();
        }
    }

  
    public void ClicksCounter()
    {
        click++;
        UpdateClickText();
    }

    IEnumerator CountCoroutine()
    {
        yield return new WaitForSeconds(1);

        while (true)
        {
            click++;
            UpdateClickText();
            yield return new WaitForSeconds(2);
        }
    }
    public void ApplyDamage(int percentage)
    {
        click = Mathf.FloorToInt(click * (1 - percentage / 100f)); 
        UpdateClickText();
    }
    
    private void UpdateClickText()
    {
        clickText.text = click.ToString();
    }
}

