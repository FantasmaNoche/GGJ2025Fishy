using UnityEngine;

public class GoInPlaceNewVer : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 targetPosition;

    void Start()
    {
        GameObject placeDeLaCrevette = GameObject.FindWithTag("PlaceDeLaCrevette");

        if (placeDeLaCrevette == null)
        {
            Debug.LogError("No GameObject with tag 'PlaceDeLaCrevette' found! Make sure to assign the correct tag.");
            return;
        }

        BoxCollider2D area = placeDeLaCrevette.GetComponent<BoxCollider2D>();
        if (area != null)
        {
            targetPosition = GetRandomPointInZone(area);
        }
        else
        {
            Debug.LogError("No BoxCollider2D found on the object with tag 'PlaceDeLaCrevette'! Assign one to define the target zone.");
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