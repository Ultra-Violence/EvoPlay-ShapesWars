using UnityEngine;
using UnityEngine.UI;

public class HistoryCanvas : MonoBehaviour
{
    [SerializeField] private ShapesSO activePlayerType;
    [SerializeField] private Text historyText;

    public void PlayBtn(){
        SetStatus(false);
        GameEvents.gameEvents.GameOn();
        activePlayerType.playerChoice = true; 
    }

    public void SetStatus(bool state){
        gameObject.GetComponent<Canvas>().enabled = state;
    }

    public void SetActivePlayerType(ShapesSO activeType){
        activePlayerType = activeType;
        historyText.text = activePlayerType.history;
    }
}
