using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrace : MonoBehaviour
{
    [SerializeField] private List<ShapesSO> ShapesList = new List<ShapesSO>();
    [SerializeField] private ShapesSO activePlayerType;

    private void Update() {
        if(activePlayerType == null){
            foreach (var shape in ShapesList)
            {
                if(shape.playerChoice == true){
                    activePlayerType = shape;
                    GetComponent<ParticleSystem>().textureSheetAnimation.AddSprite(activePlayerType.sprite);
                }
            }
        } 
    }

}
