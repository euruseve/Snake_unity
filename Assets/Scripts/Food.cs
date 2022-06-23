using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField]
    private BoxCollider2D gridArea;

    private void Start() 
    {
        RandomizePosition();    
    }

    private void RandomizePosition()
    {
        Bounds bounds = gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0f);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            RandomizePosition();    
        }
    }
}
