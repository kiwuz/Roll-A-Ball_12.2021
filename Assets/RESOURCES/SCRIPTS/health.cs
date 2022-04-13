using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class health : MonoBehaviour
{
    public static int health_ = 5;
    public static int maxHealth = 5;

    public Image[] hearts;

    public Sprite fullHeart;
    public Sprite emptyHeart;
    

    public MovementController MC;
    public checkpoint CP;
    public GameMenager GM;

    public GameObject[] water;

    void Start()
    {
        water = GameObject.FindGameObjectsWithTag("water");

        MC = FindObjectOfType<MovementController>();
        GM = FindObjectOfType<GameMenager>();
        CP = FindObjectOfType<checkpoint>();

    }

    void Update()
    {
        for (int i = 0; i < maxHealth; i++){
            if (i < health_){
                hearts[i].sprite = fullHeart;
            }
            else{
                hearts[i].sprite = emptyHeart;
            
             }
        }
    }


    void FixedUpdate(){
        CheckIfLose();

    }

    void CheckIfLose(){

        if (MC.m_Rigidbody.position.y <= -0.1){
                health_ = health_ - 1; 
                Debug.Log("zabieram serce, pozostało " + health_);
            if (health_ <= 0){
                SceneManager.LoadScene("YouLose_scene", LoadSceneMode.Single);
                Debug.Log("loser");   
                GM.ScoreReset();
                SetHealth();
                }   
            if (health_ >= 1){
                Debug.Log("teleported to checkpoint");
                MC.m_Rigidbody.transform.position = CP.checkpointPos;
                MC.m_Rigidbody.velocity = Vector3.zero;

        }
    }
}


    public void SetHealth(){
        health_ = 5;
        maxHealth = 5;
    }


}
