using UnityEngine;

public class BonusEffectScore : MonoBehaviour
{
    [SerializeField] private int scoreXBonus;
    [SerializeField] private float duration;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            other.GetComponent<PlayerScore>().AddXScoreBonus(scoreXBonus, duration);
            GameEvents.gameEvents.XScoreTrigger();
        }
    }
}
