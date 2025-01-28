using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class DespawnDeLaCrevette : MonoBehaviour
{
    public float timeToDeath = 5f;
    public GameObject SpawnCrevette;
    private Transform target;
    public float speedFuite = 8f;
    
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
