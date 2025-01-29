using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed;
    Transform myTransform;

    void Start(){
        myTransform = GetComponent<Transform>();
    }

    void Update(){
        myTransform.Translate(Vector3.up * Time.deltaTime * speed);
    }
    
}
