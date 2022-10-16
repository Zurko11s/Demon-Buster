using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform BlulletSpawnPoint;

    public float TimeBetweenShots = 0.3333f;
    private float m_timeStamp = 0f;

    void FixedUpdate()
    {
        if((Time.time >= m_timeStamp) && (Input.GetKey(KeyCode.Mouse0)))
        {
            Fire();
            m_timeStamp = Time.time + TimeBetweenShots; 
        }
    }

    void Fire()
    {
        var bullet = (GameObject)Instantiate(bulletPrefab, BlulletSpawnPoint.position, BlulletSpawnPoint.rotation);
        
        //bullet velocity
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;

        //bullet life time
        Destroy(bullet, 2.0f);

    }
}
