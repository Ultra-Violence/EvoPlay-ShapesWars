using UnityEngine;

public class BonusEffectMinusSpeed : MonoBehaviour
{
    [SerializeField] private float minusSpeed;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            other.GetComponent<Movement>().SetMoveSpeed(-minusSpeed);
            GameEvents.gameEvents.MinusSpeedTrigger();
        }
    }
}
