using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    [SerializeField] private Slider musicSlider;

    private void Start() {
        musicSlider.value = PlayerPrefs.GetFloat("musicSliderSave");
    }
    private void Update() {
        PlayerPrefs.SetFloat("musicSliderSave", musicSlider.value);
        GetComponent<AudioSource>().volume = musicSlider.value;
    }
}
