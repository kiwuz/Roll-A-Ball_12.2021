using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Portal : MonoBehaviour
{
    public int currentLevel;
    public int nextLevel;
    void Start()
    {
         currentLevel = 1;
    }

    void Update()
    {
        transform.Rotate(00 * Time.deltaTime,00* Time.deltaTime,25* Time.deltaTime);
    }

    void OnTriggerEnter(Collider collision)
    {
        currentLevel = currentLevel + 1;
        Debug.Log(currentLevel);

        SceneManager.LoadScene("Scene " + currentLevel, LoadSceneMode.Single);
    }

}
