using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameMenager GM;
    public health HP;


    public void NewGame(){

        SceneManager.LoadScene("scene 1", LoadSceneMode.Single);
        Debug.Log("loading first level");

        GM.ScoreReset();

    }


    public void ExitGame(){

        Application.Quit();

    }

    void Start()
    {
        
        GM = FindObjectOfType<GameMenager>();
        HP = FindObjectOfType<health>();

    }
}
