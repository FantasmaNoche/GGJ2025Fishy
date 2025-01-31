using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class DespawnDeLaCrevette : MonoBehaviour
{
    public float timeToDeath;
    private Transform target;
    
    
    void Update()
    {
        StartCoroutine(Despawn());
    
    }

    private void WaitForSeconds()
    {
        throw new NotImplementedException();
    }

    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(timeToDeath);
        Destroy(gameObject);
    }
    

}
