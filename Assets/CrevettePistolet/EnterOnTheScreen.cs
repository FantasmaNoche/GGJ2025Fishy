using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class EnterOnTheScreen : MonoBehaviour
{
    public int speedBullet = 7;
    public GameObject fish;
    public string detected_Fish;

    void Start()
    {
        foreach (GameObject Enemies in GameObject.FindGameObjectsWithTag("Fish"))
        {
        }
    }
}