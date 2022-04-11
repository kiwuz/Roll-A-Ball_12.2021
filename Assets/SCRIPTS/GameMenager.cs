using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;



public class GameMenager : MonoBehaviour
{

    GameObject [] Collectibles;
    public int maxSize;
    public static int score;
    public Text scoreText;
    private MovementController MC;
    public health HP;
    public event Action pickupEvent;

    void Start()
    {

        scoreText.text = "Score: " + score;

        MC = FindObjectOfType<MovementController>();
        HP = FindObjectOfType<health>();

        Collectibles = GameObject.FindGameObjectsWithTag("Collectibles");
        maxSize = Collectibles.Length;
    }

    public void CollectScore(){
        
        score +=1;
        pickupEvent?.Invoke();

        Debug.Log("Zdobyłeś punkt " + score);
        scoreText.text = "Score: " + score;
    }

    public void ScoreReset(){
            score = 0;
    }

}
