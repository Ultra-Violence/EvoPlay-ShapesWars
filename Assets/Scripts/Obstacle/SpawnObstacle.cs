using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    [SerializeField] private List<GameObject> ListOfObstacleTypes = new List<GameObject>();
    [SerializeField] private Transform playerTransform;
    [SerializeField] private GameStatus gameStatus;
    [SerializeField] private float heightSpawn;
    [SerializeField] private float spawnDelay;

    [SerializeField] private ShapesSO _activePlayerType;
    public ShapesSO activePlayerType => _activePlayerType;
    public void SetActivePlayerType(ShapesSO activeType){
        _activePlayerType = activeType;
    }

    private void Start() {
        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles(){
        while (true)
        {   
            yield return new WaitForSeconds(spawnDelay);

            if(gameStatus.GetStatus() == true){
                int randomNumber = Random.Range(0, ListOfObstacleTypes.Count);
                Instantiate(ListOfObstacleTypes[randomNumber], new Vector3(0, playerTransform.position.y + heightSpawn, 0), Quaternion.identity);
            } 
        }
    }
}
