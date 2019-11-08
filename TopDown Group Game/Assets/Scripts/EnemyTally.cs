using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTally : MonoBehaviour
{
    public int enemyTotal = 0;
    // Start is called before the first frame update
    void Start()
    {
        FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
