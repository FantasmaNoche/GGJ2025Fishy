using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public float timeToDeath = 3f;
    public float speedBullet = 5f;
    private Vector3 myTarget = new Vector3(6.4f, -2.07f, 0.0f);
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
        if (collision.gameObject.CompareTag("Fish"))
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }
    }

}