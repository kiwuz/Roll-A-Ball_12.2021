using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class winner : MonoBehaviour
{


    public GameMenager GM;
    void Start()
    {

     GM = FindObjectOfType<GameMenager>();

    }

    void OnTriggerEnter(Collider colllider){
        SceneManager.LoadScene("YouWon_scene", LoadSceneMode.Single);
        Debug.Log("winner");   
        GM.ScoreReset();
    }
}
