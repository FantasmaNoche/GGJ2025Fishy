using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GoInPlace : MonoBehaviour
{
    private Transform target;
    public float speed = 5f;
    private GameObject PlaceDeLaCrevette;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("PlaceDeLaCrevette").GetComponent<Transform>();

    }


    void Update()
    {
        
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

    }
}
