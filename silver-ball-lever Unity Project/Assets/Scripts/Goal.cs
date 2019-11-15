using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detect when the ball touches to goal to show a win message
/// </summary>
public class Goal : MonoBehaviour
{

    public GameObject WinText;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched Trigger");

        if (collision.tag == "Player" && !GameOver.isGameOver)
        {
            WinText.SetActive(true); //tells us we win

            audioSource.Play();

            Debug.Log("You touched the goal");
        }
    }
}
