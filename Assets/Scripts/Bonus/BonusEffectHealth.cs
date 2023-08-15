using UnityEngine;

public class BonusEffectHealth : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            other.GetComponent<PlayerData>().GetHeal();
            GameEvents.gameEvents.HealTrigger();
        }
    }
}
