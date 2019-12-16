using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restarting : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("Restart the Game");
            SceneManager.LoadScene("Game");
        }
        else if (Input.GetKey(KeyCode.Backspace))
        {
            SceneManager.LoadScene("GameTitle");
        }

    }
}
