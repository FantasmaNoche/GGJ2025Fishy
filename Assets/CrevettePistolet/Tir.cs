using System.Collections;
using UnityEditor;
using UnityEngine;

public class Tir : MonoBehaviour

{
    public GameObject spawnPoint;
    public GameObject bullet;
    public float shotTime;
    public float startTime;
    private float elapsedTime;

    void Start()
    {
            startTime = Time.time;
        Instantiate(bullet, spawnPoint.transform.position, bullet.transform.rotation);
    }
   

    void Update(){
        elapsedTime = Time.time - startTime;

        if (elapsedTime >= shotTime){
            startTime = Time.time;
            Instantiate(bullet, spawnPoint.transform.position, bullet.transform.rotation);

        }
    }

   
}