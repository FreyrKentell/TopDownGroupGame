using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public bool firstTime1 = true;
    public bool firstTime2 = true;
    public bool firstTime3 = true;
    public bool firstTime4 = true;
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
            if (firstTime1 == true)
            {
                GameObject enemy = Instantiate(WaveOne, transform.position, Quaternion.identity);
                firstTime1 = false;
            }
            else if (firstTime1 == false)
            {
                return;
            }

        }
        if (currentTimer >= waveTwo)
        {
            if (firstTime2 == true)
            {
                GameObject enemy = Instantiate(WaveTwo, transform.position, Quaternion.identity);
                firstTime2 = false;
            }
        }
        else if (firstTime2 == false)
        {
            return;
        }
        if (currentTimer >= waveThree)
        {
            if (firstTime3 == true)
            {
                GameObject enemy = Instantiate(WaveThree, transform.position, Quaternion.identity);
                firstTime3 = false;
            }
        }
        else if (firstTime3 == false)
        {
            return;
        }
        if (currentTimer >= waveFour)
        {
            if (firstTime4 == true)
            {
                GameObject enemy = Instantiate(WaveFour, transform.position, Quaternion.identity);
                firstTime4 = false;
            }
            else if (firstTime4 == false)
            {
                return;
            }

        }
    }
}