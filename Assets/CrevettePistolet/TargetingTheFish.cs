using System;
using UnityEngine;

public class TargetingTheFish : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 100f;
    public float speed = 10f;




    void Start()
    {
        if (target == null && GameObject.FindGameObjectWithTag("Fishy") != null)
        {
            target = GameObject.FindGameObjectWithTag("Fishy").transform;
        }
    }
        private void FixedUpdate()
    {
        if (target == null) return;
        Vector2 direction = (Vector2)target.position - (Vector2)transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }   
        
}
