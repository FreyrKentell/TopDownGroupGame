using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Collision)
    {
    if (Collision.gameObject.tag == "Player")
    
        SceneManager.LoadScene("Level 1");
    

    }
    
}
