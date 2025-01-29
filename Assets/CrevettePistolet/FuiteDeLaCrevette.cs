using Unity.VisualScripting;
using UnityEngine;

public class FuiteDeLaCrevette : MonoBehaviour
{
    public int speed;
    public GameObject pointDeFuite;
    public float tempsAvantLaFuite;
    private Transform target;
    void Start()
    {
        
        target = GameObject.FindGameObjectWithTag("SpawnCrevette").GetComponent<Transform>();

    }

    //void OnCollisionEnter2D(Collision2D collision)

   // {
       // yield return new WaitForSeconds(tempsAvantLaFuite);
        //if (collision.gameObject.CompareTag("PlaceDeLaCrevette"))
        //{
          //  transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        //}
 //}
}
