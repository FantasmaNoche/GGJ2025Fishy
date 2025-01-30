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
        int random = Random.Range(0, crevettes.Length);

        CrevetteController crevetteToSpawn = crevettes[random];

        CrevetteController createdCrevette = Instantiate(crevetteToSpawn);

        createdCrevette.transform.position = transform.position;
    }
    
}
