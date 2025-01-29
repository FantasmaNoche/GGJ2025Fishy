using System.Collections;
using UnityEngine;

public class SpawnerCrevette : MonoBehaviour
{
    public GameObject crevettePrefab;
    public float interval = 100;
    private float counter = 0;


    void FixedUpdate()
    {
        counter += 1;

        if (counter >= interval)
        {
            counter = 0;
            Instantiate(crevettePrefab, transform.position, transform.rotation);

        }
    }

}
