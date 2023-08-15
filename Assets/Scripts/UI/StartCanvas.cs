using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCanvas : MonoBehaviour
{
    [SerializeField] private List<ShapesSO> ShapesList = new List<ShapesSO>();
    
    private void Start() {
        foreach (var shape in ShapesList)
        {
            if(shape.playerChoice == true){
                SetStatus(false);
                GameEvents.gameEvents.GameOn();
            }
        }
        
    }
    public void SetStatus(bool state){
        gameObject.GetComponent<Canvas>().enabled = state;
    }
}
