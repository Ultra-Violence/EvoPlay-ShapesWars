using UnityEngine;

public class Movement : MonoBehaviour

{
    private float deltaX;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float controlSpeed;
    [SerializeField] private GameStatus gameStatus;

    private void FixedUpdate() {
        if(gameStatus.GetStatus() == true){
            transform.position += Vector3.up * Time.fixedDeltaTime * moveSpeed;
        

        deltaX = transform.position.x;
        deltaX = Mathf.Clamp(deltaX, -2.4f, 2.4f);

        transform.position = new Vector3(deltaX, transform.position.y, transform.position.z);

        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);

            Vector3 touchPos = touch.position;

            if(touchPos.x < Screen.width/2){
                transform.position += Vector3.left * Time.fixedDeltaTime * controlSpeed;
            }
            else if(touchPos.x > Screen.width/2){
                transform.position += Vector3.right * Time.fixedDeltaTime * controlSpeed;
            }
        }
        }
    }

    public void SetMoveSpeed(float bonusMoveSpeed){
        moveSpeed += bonusMoveSpeed;
    }
}
