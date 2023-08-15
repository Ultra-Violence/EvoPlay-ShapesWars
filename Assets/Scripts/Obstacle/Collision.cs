using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] private ShapesSO activeType;

    private ShapesSO activePlayerType;
    private PlayerData playerData;
    private PlayerScore playerScore;
    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){

            activePlayerType = other.GetComponent<PlayerType>().activePlayerType;
            playerData = other.GetComponent<PlayerData>();
            playerScore = other.GetComponent<PlayerScore>();

            if(activeType == activePlayerType.openType){
                playerScore.AddPoints();
                animator.SetTrigger("Die");
                GameEvents.gameEvents.CollisionOpenTrigger();
                GetComponent<BoxCollider2D>().enabled = false;
            } 
            else if(activeType == activePlayerType.closeType){
                playerData.GetDamage();
                GameEvents.gameEvents.CollisionCloseTrigger();
                GameEvents.gameEvents.CameraShakeTrigger();
                Destroy(gameObject);
            } 
        }

          
    }

    
}
