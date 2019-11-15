using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public GameObject GameOverText;
    private AudioSource audioSource;
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
            GameOver.isGameOver = true;
            

            Debug.Log("You touched the bad object");
        }
    }
}
