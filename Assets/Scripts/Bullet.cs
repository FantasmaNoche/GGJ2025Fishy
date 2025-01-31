using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform pointDeTir;
    public GameObject projectilePrefab;
    public float vitesseProjectile = 10f;
    void Update()
    {
        // Tir normal
        if (Input.GetKey(KeyCode.Space)) 
        {
        
                Tirer();
              
        }
        
        void Tirer()
        {
            
            GameObject projectile = Instantiate(projectilePrefab, pointDeTir.position, pointDeTir.rotation);
            Physics2D.IgnoreCollision(projectilePrefab.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = pointDeTir.right * vitesseProjectile; // Le projectile se d�place dans la direction du "up" du point de tir
            } }

     
    }
}

