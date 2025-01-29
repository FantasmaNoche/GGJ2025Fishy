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
        if (collision.gameObject.CompareTag("FishyLvl1"))
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }
        if (collision.gameObject.CompareTag("FishyLvl2"))
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }
        if (collision.gameObject.CompareTag("FishyLvl3"))
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }
        if (collision.gameObject.CompareTag("FishyLvl4"))
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }
        if (collision.gameObject.CompareTag("FishyLvl5"))
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }
    }

}