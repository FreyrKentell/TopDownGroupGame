﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int health = 10;
    public Text healthText;
    public Slider healthSlider;
  
    void Start()
    {
        healthText.text = "Health: " + health;
        healthSlider.maxValue = health;
        healthSlider.value = health;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
            health--;
        healthText.text = "Health: " + health;
        healthSlider.value = health;
        if (health <= 0)
        {
           
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                


        }
    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "Health: " + health;
            healthSlider.value = health;
            if(health <= 0)
            {
                
            
                     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    
            }
               
        }
    }
}
