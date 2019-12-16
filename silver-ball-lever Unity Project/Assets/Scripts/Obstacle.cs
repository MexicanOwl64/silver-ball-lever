using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public GameObject GameOverText;
    private AudioSource audioSource;
    public GameObject Player;
    public GameObject Ramp;
    public GameObject LeftSupport;
    public GameObject RightSupport;
    
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched Trigger");

        if (collision.tag == "Player")
        {
            GameOverText.SetActive(true); //tells us we win
            Player.SetActive(false);
            Ramp.SetActive(false);
            LeftSupport.SetActive(false);
            RightSupport.SetActive(false);
            
            GameOver.isGameOver = true;

            audioSource.Play();

            Debug.Log("You touched the bad object");
        }
        else
        {
            GameOver.isGameOver = false;
        }

    }
}
