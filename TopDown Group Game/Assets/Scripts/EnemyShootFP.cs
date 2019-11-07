﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootFP : MonoBehaviour
{
    float timer = 0;
    public float bulletSpeed = 5.0f;
    public float bulletLifetime = 3.0f;
    public float shootDelay = 0.5f;
    public Transform player;
    public GameObject prefab;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > shootDelay)
        {
            timer = 0;
            Debug.Log("HEY");
            GameObject bullet = Instantiate(prefab, firePoint.position, Quaternion.identity);//firePoint.rotation);
            Vector2 shootDir = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
            Destroy(bullet, bulletLifetime);
        }
    }
}

