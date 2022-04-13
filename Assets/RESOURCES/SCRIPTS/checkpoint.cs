using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class checkpoint : MonoBehaviour
{
    public AudioClip coinSound;
    public Vector3 checkpointPos;
    public MovementController MC;
    private Animator checpointAnim;
    [SerializeField] private Text checkpointText;

    void Start()
    {
         MC = FindObjectOfType<MovementController>();
         checkpointPos = new Vector3(-55,2.5f,-105);
         checpointAnim = checkpointText.GetComponent<Animator>();
    }

    void Update()
    {
        transform.Rotate(0 * Time.deltaTime,30* Time.deltaTime,10* Time.deltaTime);

    }

    void OnTriggerEnter(Collider collision)
    {
        AudioSource.PlayClipAtPoint(coinSound,transform.position);
        checkpointPos = transform.position;
        checpointAnim.SetTrigger("checkpointAnim");
        gameObject.SetActive(false);   

    }
}
