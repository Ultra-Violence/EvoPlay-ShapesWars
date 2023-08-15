using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private List<GameObject> BonusesList = new List<GameObject>();
    private float timeToDestroy = 5f;
    private void Start() {
        int randomIndex = Random.Range(0, BonusesList.Count);
        Instantiate(BonusesList[randomIndex], transform);
        Destroy(gameObject, timeToDestroy);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            Destroy(gameObject);
        }
    }

}
