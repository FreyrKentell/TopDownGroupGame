using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TaxCollect : MonoBehaviour
{
    public int scoreCount = 0;
    public Text scoreText;

    void Start()
    {
        scoreText.text = "Score: " + scoreCount;  
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Plus")
        {
            scoreCount++;
            scoreText.text = "Score: " + scoreCount;
            if(scoreCount >= 10)
            {
                SceneManager.LoadScene("Win");
            }
            Debug.Log("Come with me, new friend!");

            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Minus")
        {
            scoreCount--;
            if(scoreCount < -10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            Debug.Log("THEY DID NOT WANT TO BE FRIENDS!");

            Destroy(collision.gameObject);
        }
    }
}
