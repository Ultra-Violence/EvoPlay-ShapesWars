using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBonus : MonoBehaviour
{
    [SerializeField] private List<ShapesSO> ShapesList = new List<ShapesSO>();
    [SerializeField] private Transform playerTransform;
    [SerializeField] private GameStatus gameStatus;
    [SerializeField] private float heightSpawn;
    [SerializeField] private float spawnDelay;

    private GameObject activeBonusType;

    private void Start() {
        StartCoroutine(SpawnBonuses());
    }

    private void Update() {
        if(activeBonusType == null){
            foreach (var shape in ShapesList)
            {
                if(shape.playerChoice == true){
                    activeBonusType = shape.bonusPrefab;
                }
            }
        }
    }

    IEnumerator SpawnBonuses(){
        while (true)
        {   
            yield return new WaitForSeconds(spawnDelay);

            if(gameStatus.GetStatus() == true){
                float randomX = Random.Range(-2.5f, 2.5f);
                Instantiate(activeBonusType, new Vector3(randomX, playerTransform.position.y + heightSpawn, 0), Quaternion.identity);
            } 
        }
    }
}
