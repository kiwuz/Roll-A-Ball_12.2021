using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public AudioClip coinSound;
    public GameMenager GM;

    void Start()
    {

        GM = FindObjectOfType<GameMenager>();
        
    }

    void Update()
    {

        transform.Rotate(0 * Time.deltaTime,200* Time.deltaTime,0* Time.deltaTime);
        
    }


    void OnTriggerEnter(Collider collision)
    {
        GM.CollectScore();
        AudioSource.PlayClipAtPoint(coinSound,transform.position);
        gameObject.SetActive(false);
        
    }
}
