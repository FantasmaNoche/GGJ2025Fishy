using UnityEngine;

public class CrevetteSpawner : MonoBehaviour
{
    public AnimationCurve spawnRateAlongFishSize;

    public CrevetteController[] crevettes;


    [Range(0, 30)]
    public int maxSpawnRate;

    private PlayerData player;
    private float currentTime;
    

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        player = FindFirstObjectByType<PlayerData>();
        if (player == null)
        {
            Debug.LogError("PlayerData not found in the scene! Make sure an object with PlayerData exists.");
        }
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        currentTime += Time.deltaTime;
        
        // Produit en croix
        float iLerp = Mathf.InverseLerp(player.minSize, player.maxSize, player.currentSize);

        float spawnTime = 1f / (spawnRateAlongFishSize.Evaluate(iLerp) * maxSpawnRate);

        if(currentTime  >= spawnTime)
        {
            currentTime = 0;
            SpawnFish();
        }
    }

    private void SpawnFish()
    {
        if (crevettes == null || crevettes.Length == 0)
        {
            Debug.LogError("Crevettes array is empty or unassigned! Assign it in the Inspector.");
            return;
        }

        int random = Random.Range(0, crevettes.Length);
        CrevetteController crevetteToSpawn = crevettes[random];

        if (crevetteToSpawn == null)
        {
            Debug.LogError("Selected CrevetteController is null! Check the array in the Inspector.");
            return;
        }

        CrevetteController createdCrevette = Instantiate(crevetteToSpawn);
        createdCrevette.transform.position = transform.position;
    }
    
}
