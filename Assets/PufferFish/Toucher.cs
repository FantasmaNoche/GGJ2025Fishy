using UnityEngine;

public class Toucher : MonoBehaviour
{
    public GameObject bullet;
    public bool toucher;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "ShrimpBubbles")
        {
            Debug.Log("Toucher");

        }
    }
}