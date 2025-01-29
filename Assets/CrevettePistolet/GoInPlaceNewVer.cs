using UnityEngine;

public class GoInPlaceNewVer : MonoBehaviour
{
    public float speed = 5f;
    public GameObject PlaceDeLaCrevette;
    private Vector2 targetPosition;

    void Start()
    {
        BoxCollider2D area = PlaceDeLaCrevette.GetComponent<BoxCollider2D>();
        if (area != null)
        {
            targetPosition = GetRandomPointInZone(area);
        }
        else
        {
            Debug.LogError("No BoxCollider2D found on PlaceDeLaCrevette! Assign one to define the target zone.");
        }
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    private Vector2 GetRandomPointInZone(BoxCollider2D area)
    {
        Bounds bounds = area.bounds;
        float randomX = Random.Range(bounds.min.x, bounds.max.x);
        float randomY = Random.Range(bounds.min.y, bounds.max.y);
        return new Vector2(randomX, randomY);
    }
}