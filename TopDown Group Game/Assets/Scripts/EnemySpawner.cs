using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public bool firstTime = true;
    public float currentTimer = 0.0f;
    public float waveOne = 1.0f;
    public float waveTwo = 2.0f;
    public float waveThree = 3.0f;
    public float waveFour = 4.0f;
    public GameObject WaveOne;
    public GameObject WaveTwo;
    public GameObject WaveThree;
    public GameObject WaveFour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime;
        Mathf.RoundToInt(currentTimer);
        if (currentTimer >= waveOne)
        {
            if (firstTime == true)
            {
                GameObject enemy = Instantiate(WaveOne, transform.position, Quaternion.identity);
            }else if (firstTime ==false)
                {
                return;
                }
           
        } 
    }
}
