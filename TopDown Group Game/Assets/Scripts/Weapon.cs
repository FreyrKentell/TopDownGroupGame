using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    float lastX = 0;
    float lastY = 0;
    Vector2 pushDir;
    public int ammo;
    public float reloadTime = 2.0f;
    public float reloadCurrent = 0.0f;
    public int maxAmmo = 10;
    public Canvas reloadCanvas;
    public int reloadTimer;
    public int currentTimer;
    private void Start()
    {
        pushDir = new Vector2(1, 0);
    }
    // Update is called once per frame
    void Update()
    {
        //pushDir = Vector2.zero;
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        if(x != 0 && lastX == 0)
        {
            pushDir = new Vector2(x, 0);
        }else if (y != 0 && lastY == 0)
        {
            pushDir = new Vector2(0, y);
        }
        if (Input.GetButtonDown("Fire1") && ammo > 0)
        {
            Shoot();
            
        }
        lastX = x;
        lastY = y;
    }
    
    void Shoot()
    {
        /*if(Mathf.Abs(x) > Mathf.Abs(y))
        {
            if(x > 0)
            {
                pushDir.x = 1;
            }
            else
            {
                pushDir.x = -1;
            }
        }else if (Mathf.Abs(x) < Mathf.Abs(y))
        {
            if(y > 0)
            {
                pushDir.y = 1;
            }
            else
            {
                pushDir.y = -1;
            }
        }*/
        // shooting logic

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = pushDir * bulletSpeed;
        bullet.GetComponent<Animator>().SetFloat("x", pushDir.x);
        bullet.GetComponent<Animator>().SetFloat("y", pushDir.y);
    }
}
