using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private Menu menu;
    [SerializeField] private Color defaultColor;
    [SerializeField] private Color immunitytColor;

    private float immunityEndTime = 0f;
    private bool immunity = false;
    private SpriteRenderer spriteRenderer;
    
    private int _health = 3;
    public int health => _health;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void GetDamage(){
        if(immunity == false){
            _health--;
        }
    }

    public void GetHeal(){
        _health++;
    }

    public void GetImmunityBonus(float duration){
        immunity = true;
        immunityEndTime = Time.time + duration;
    }

    private void Update() {
        if(_health <= 0){
            menu.SetStatus(true);
            GameEvents.gameEvents.GameOff();
        }
        else if(_health > 3){
            _health = 3;
        }

        if(immunity == true){
            spriteRenderer.color = immunitytColor;
        }
        else {
            spriteRenderer.color = defaultColor;
        }

        if(immunity && Time.time >= immunityEndTime) {
            immunity = false; 
            }
    }
}


