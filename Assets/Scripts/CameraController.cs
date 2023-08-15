using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float cameraHeight;
    [SerializeField] private float shakeMagnitude = 0.1f;
    [SerializeField] private float shakeDuration;

    private bool shaking = false;
    private float shakeTime = 0f;
    private Vector3 originalPosition;

    private void Start()
    {
        GameEvents.gameEvents.onCameraShakeTrigger += ShakeTrigger;
    }

    public void ShakeTrigger()
    {
        StartShake(shakeDuration);
    }

    public void StartShake(float duration)
    {
        shaking = true;
        shakeTime = duration;
        originalPosition = transform.localPosition;
    }

    private void Update()
    {
        if (shaking && shakeTime > 0)
        {
            Vector3 shakeOffset = Random.insideUnitCircle * shakeMagnitude;
            transform.localPosition = originalPosition + new Vector3(shakeOffset.x, shakeOffset.y, 0);
            shakeTime -= Time.deltaTime;
        }
        else
        {
            shaking = false;
            shakeTime = 0f;
        }

        float posY = playerTransform.position.y + cameraHeight;
        if(playerTransform.position.y >= -cameraHeight && shaking == false){
            transform.position = new Vector3(0, posY, -10);
        }
    }
}
