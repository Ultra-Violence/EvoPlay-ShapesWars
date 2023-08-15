using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private int numberOfOpen;
    [SerializeField] private int numberOfClose;

    private ShapesSO activePlayerType;
    private GameObject player;
    private GameObject randomUnit;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        activePlayerType = player.GetComponent<PlayerType>().activePlayerType;

        float posX = -2.5f;

        for (int i = 0; i < 5; i++)
        {
            int randomNumber = Random.Range(0, 2);

            if(randomNumber == 0 && numberOfOpen > 0){
                randomUnit = activePlayerType.openType.prefab;
                numberOfOpen--;
            }
            else if(randomNumber == 0 && numberOfOpen == 0){
                randomUnit = activePlayerType.closeType.prefab;
                numberOfClose--;
            }
            else if(randomNumber == 1 && numberOfClose > 0){
                randomUnit = activePlayerType.closeType.prefab;
                numberOfClose--;
            }
            else if(randomNumber == 1 && numberOfClose == 0){
                randomUnit = activePlayerType.openType.prefab;
                numberOfOpen--;
            }

            Instantiate(randomUnit, new Vector3(posX, transform.position.y , 0), Quaternion.Euler(0, 0, 180), transform);
            posX += 1.25f;
        }
    }

    private void Update() {
        if(transform.position.y < player.GetComponent<Transform>().position.y - 5f){
            Destroy(gameObject);
        }
    }


}
