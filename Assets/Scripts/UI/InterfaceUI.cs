using UnityEngine;

public class InterfaceUI : MonoBehaviour
{
    [SerializeField] private GameStatus gameStatus;

    private void Update() {
        if(gameStatus.GetStatus() == true){
            GetComponent<Canvas>().enabled = true;
        }
        else {
            GetComponent<Canvas>().enabled = false;
        }
    }
    
}
