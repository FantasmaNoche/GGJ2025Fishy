using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class DespawnDeLaCrevette : MonoBehaviour
{
    public float timeToDeath;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(Despawn());
    }

    IEnumerator Despawn()
    {
       
        animator.SetBool("isDead", true);

        
        yield return new WaitForSeconds(timeToDeath);

       
        Destroy(gameObject);
    }
}
