using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerType : MonoBehaviour
{
    [SerializeField] private List<ShapesSO> ShapesList = new List<ShapesSO>();

    private ShapesSO _activePlayerType;
    public ShapesSO activePlayerType => _activePlayerType;

    private void Update() {
        if(_activePlayerType == null){
            foreach (var shape in ShapesList)
            {
                if(shape.playerChoice == true){
                    _activePlayerType = shape;
                    GetComponent<SpriteRenderer>().sprite = _activePlayerType.sprite;
                    GameEvents.gameEvents.GameOn();
                }
            }
        }
    }
}
