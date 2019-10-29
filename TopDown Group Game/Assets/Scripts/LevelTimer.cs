using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{
    public float currentTimer = 0;
    public int startTimer = 30;
    public Text timerText;
    public int NextLevel = 1;
    // Start is called before the first frame update
    void Start()
    {
        currentTimer = startTimer;
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer -= Time.deltaTime;
        timerText.text = "Time Left: " + Mathf.RoundToInt(currentTimer);
        if(currentTimer <= 0)
        {
            currentTimer = 0;
            SceneManager.LoadScene(NextLevel);
        }
    }
}
