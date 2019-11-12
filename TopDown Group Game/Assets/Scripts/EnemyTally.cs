using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTally : MonoBehaviour
{
    public GameObject Boss;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy");

        if (gameObjects.Length == 0)
        {
            Debug.Log("No game objects are tagged with 'Enemy'");
            GameObject enemy = Instantiate(Boss, transform.position, Quaternion.identity);
        }
    }
    void Update()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy");

        if (gameObjects.Length == 0)
        {
            Debug.Log("No game objects are tagged with 'Enemy'");
            GameObject enemy = Instantiate(Boss, transform.position, Quaternion.identity);
        }
    }
    }