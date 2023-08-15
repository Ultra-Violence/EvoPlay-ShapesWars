using UnityEngine;

public class GameStatus : MonoBehaviour
{
    private bool gameOn = false;

    private void Start() {
        GameEvents.gameEvents.onGameOnTrigger += GameOn;
        GameEvents.gameEvents.onGameOffTrigger += GameOff;
    }

    public bool GetStatus(){
        return gameOn;
    }

    public void GameOn(){
        gameOn = true;
    }

    public void GameOff(){
        gameOn = false;
    }



}
