using UnityEngine;

[CreateAssetMenu(fileName = "ShapesSO")]
public class ShapesSO : ScriptableObject 
{
    public string nameShape;
    public string history;
    public GameObject prefab;
    public GameObject bonusPrefab;
    public Sprite sprite;
    public ShapesSO openType;
    public ShapesSO closeType;
    public bool playerChoice;
}
