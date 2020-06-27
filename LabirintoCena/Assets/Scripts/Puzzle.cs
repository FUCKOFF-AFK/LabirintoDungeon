using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle : MonoBehaviour
{
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
