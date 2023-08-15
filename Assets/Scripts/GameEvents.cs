using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents gameEvents;

    private void Awake() {
        gameEvents = this;
    }

    public event Action onCameraShakeTrigger;
    public void CameraShakeTrigger(){
        if(onCameraShakeTrigger != null){
            onCameraShakeTrigger();
        }
    }

    public event Action onGameOnTrigger;
    public void GameOn(){
        if(onGameOnTrigger != null){
            onGameOnTrigger();
        }
    }

    public event Action onGameOffTrigger;
    public void GameOff(){
        if(onGameOffTrigger != null){
            onGameOffTrigger();
        }
    }

    public event Action onMinusSpeedTrigger;
    public void MinusSpeedTrigger(){
        if(onMinusSpeedTrigger != null){
            onMinusSpeedTrigger();
        }
    }

    public event Action onImmunityTrigger;
    public void ImmunityTrigger(){
        if(onImmunityTrigger != null){
            onImmunityTrigger();
        }
    }

    public event Action onHealTrigger;
    public void HealTrigger(){
        if(onHealTrigger != null){
            onHealTrigger();
        }
    }

    public event Action onXScoreTrigger;
    public void XScoreTrigger(){
        if(onXScoreTrigger != null){
            onXScoreTrigger();
        }
    }

    public event Action onCollisionOpenTrigger;
    public void CollisionOpenTrigger(){
        if(onCollisionOpenTrigger != null){
            onCollisionOpenTrigger();
        }
    }

    public event Action onCollisionCloseTrigger;
    public void CollisionCloseTrigger(){
        if(onCollisionCloseTrigger != null){
            onCollisionCloseTrigger();
        }
    }
}
