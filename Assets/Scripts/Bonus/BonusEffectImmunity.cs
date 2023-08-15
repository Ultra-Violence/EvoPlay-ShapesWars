using UnityEngine;

public class BonusEffectImmunity : MonoBehaviour
{
    [SerializeField] private float duration;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            other.GetComponent<PlayerData>().GetImmunityBonus(duration);
            GameEvents.gameEvents.ImmunityTrigger();
        }
    }
}
