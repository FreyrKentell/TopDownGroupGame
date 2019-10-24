using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        SceneManager.LoadScene("Level 1");
    }
}
