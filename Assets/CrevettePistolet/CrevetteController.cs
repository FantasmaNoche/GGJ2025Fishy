using UnityEngine;

public class CrevetteController : MonoBehaviour
{
    [HideInInspector]
    public PlayerData player;


    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        player = FindFirstObjectByType<PlayerData>();
    }
}
