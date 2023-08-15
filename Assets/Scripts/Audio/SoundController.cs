using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    [SerializeField] private Slider soundSlider;

    [SerializeField] private AudioClip minusSpeedSound;
    [SerializeField] private AudioClip immunitySound;
    [SerializeField] private AudioClip healSound;
    [SerializeField] private AudioClip xScoreSound;
    [SerializeField] private AudioClip openCollisionSound;
    [SerializeField] private AudioClip closeCollisionSound;

    private AudioSource audioComponent;



    private void Start() {
        audioComponent = GetComponent<AudioSource>();

        soundSlider.value = PlayerPrefs.GetFloat("soundSliderSave");

        GameEvents.gameEvents.onMinusSpeedTrigger += MinusSpeedSound;
        GameEvents.gameEvents.onImmunityTrigger += ImmunitySound;
        GameEvents.gameEvents.onHealTrigger += HealSound;
        GameEvents.gameEvents.onXScoreTrigger += XScoreSound;
        GameEvents.gameEvents.onCollisionOpenTrigger += CollisionOpen;
        GameEvents.gameEvents.onCollisionCloseTrigger += CollisionClose;
    }

    public void MinusSpeedSound(){
        audioComponent.clip = minusSpeedSound;
        audioComponent.Play(0);
    }

    public void ImmunitySound(){
        audioComponent.clip = immunitySound;
        audioComponent.Play(0);
    }

    public void HealSound(){
        audioComponent.clip = healSound;
        audioComponent.Play(0);
    }

    public void XScoreSound(){
        audioComponent.clip = xScoreSound;
        audioComponent.Play(0);
    }

    public void CollisionOpen(){
        audioComponent.clip = openCollisionSound;
        audioComponent.Play(0);
    }

    public void CollisionClose(){
        audioComponent.clip = closeCollisionSound;
        audioComponent.Play(0);
    }

    private void Update() {
        PlayerPrefs.SetFloat("soundSliderSave", soundSlider.value);
        audioComponent.volume = soundSlider.value;
    }


}
