using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private List<ShapesSO> ShapesList = new List<ShapesSO>();

    public void ReElectShapeBtn(){
        foreach (var shape in ShapesList)
        {
            shape.playerChoice = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void RetryBtn(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SetStatus(bool state){
        gameObject.GetComponent<Canvas>().enabled = state;
    }
}
