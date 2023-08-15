using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private float plusMoveSpeedAfterOpen;

    private Movement movement;

    private int _score;
    private int _maxScore;
    private int _xScore = 1;
    public int score => _score;
    public int maxScore => _maxScore;
    public int xScore => _xScore;
    
    private float xScoreBonusEndTime = 0f;

    private void Start() {
        movement = GetComponent<Movement>();
        _maxScore = PlayerPrefs.GetInt("maxScoreSave");
    }

    public void AddPoints(){
        _score += xScore;
        movement.SetMoveSpeed(plusMoveSpeedAfterOpen);
        
        if(_score >= _maxScore){
            PlayerPrefs.SetInt("maxScoreSave", _maxScore);
            _maxScore = _score;
        }
        
    }

    public void AddXScoreBonus(int xScoreBonus, float duration){
        _xScore = xScoreBonus;
        xScoreBonusEndTime = Time.time + duration;
    }

    private void Update() {
        if (Time.time >= xScoreBonusEndTime) {
            _xScore = 1;
        }

    }


}
