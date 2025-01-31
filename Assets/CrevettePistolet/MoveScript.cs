using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public float timeToDeath = 3f;
    public GameObject bullet;

   

    void Start()
    {
        StartCoroutine(Despawn());
    }
    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(timeToDeath);
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fishy"))
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }
       
    }

}