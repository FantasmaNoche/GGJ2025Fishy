using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class FuiteDeLaCrevette : MonoBehaviour
{
  public float tempsAvantLaFuite;
  public float speedFuite;
  private GameObject PointDeFuite;
  private Transform target;


  void Start(){

    target = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Transform>();
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
      transform.position = Vector2.MoveTowards(transform.position, target.position, speedFuite * Time.deltaTime);
      yield return null;
    }
  }
}
