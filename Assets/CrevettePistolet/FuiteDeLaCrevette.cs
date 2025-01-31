using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class FuiteDeLaCrevette : MonoBehaviour
{
  public float tempsAvantLaFuite;
  public float speedFuite;
  private Transform target;
  private SpriteRenderer spriteRenderer;
 

  void Start()
  {
    target = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Transform>();
    spriteRenderer = GetComponent<SpriteRenderer>();
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.CompareTag("PlaceDeLaCrevette"))
    {
      Debug.Log("Fuite");
      StartCoroutine(Fuite());
    }
  }

  private IEnumerator Fuite()
  {
    yield return new WaitForSeconds(tempsAvantLaFuite);

    while (Vector2.Distance(transform.position, target.position) > 0.1f)
    {

      Vector2 direction = (target.position - transform.position).normalized;


      if (direction.x > 0)
        spriteRenderer.flipX = false; 
      else if (direction.x < 0)
        spriteRenderer.flipX = true; 

      
      transform.position = Vector2.MoveTowards(transform.position, target.position, speedFuite * Time.deltaTime);
      yield return null;
    }
  }
}