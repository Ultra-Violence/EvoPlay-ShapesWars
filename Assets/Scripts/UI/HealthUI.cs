using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private Image heart1;
    [SerializeField] private Image heart2;
    [SerializeField] private Image heart3;

    private int health;

    private void Update() {
        health = playerData.health;

        if(health == 3){
            heart1.color = Color.white;
            heart2.color = Color.white;
            heart3.color = Color.white;
        }
        else if(health == 2){
            heart1.color = Color.white;
            heart2.color = Color.white;
            heart3.color = Color.black;
        }
        else if(health == 1){
            heart1.color = Color.white;
            heart2.color = Color.black;
            heart3.color = Color.black;
        }
        else if(health == 0){
            heart1.color = Color.black;
            heart2.color = Color.black;
            heart3.color = Color.black;
        }
    }


}
