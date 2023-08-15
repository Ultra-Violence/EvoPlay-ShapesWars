using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float amplitude = 1.0f;
    [SerializeField] private float frequency = 1.0f;
    private float startY;

    private float timeOffset;

    private void Start(){ 
        startY = transform.position.y;
        timeOffset = Random.Range(0f, 2 * Mathf.PI);
    }

    private void Update(){
        float newY = startY + Mathf.Sin((Time.time + timeOffset) * frequency) * amplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
