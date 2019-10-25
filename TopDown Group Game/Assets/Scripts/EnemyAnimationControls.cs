﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAnimationControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 desiredVelocity = GetComponent<AIPath>().desiredVelocity;
        desiredVelocity.Normalize();
        GetComponent<Animator>().SetFloat("x", desiredVelocity.x);
        GetComponent<Animator>().SetFloat("y", desiredVelocity.y);
    }
}
