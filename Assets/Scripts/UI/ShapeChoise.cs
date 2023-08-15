using UnityEngine;

public class ShapeChoise : MonoBehaviour
{
    [SerializeField] private ShapesSO activeType;

    [SerializeField] private StartCanvas startCanvas;
    [SerializeField] private HistoryCanvas historyCanvas;
    [SerializeField] private SpawnObstacle spawnObstacle;

    public void PressBtn(){
        historyCanvas.SetActivePlayerType(activeType);
        spawnObstacle.SetActivePlayerType(activeType);
        historyCanvas.SetStatus(true);
        startCanvas.SetStatus(false);
    }
}
