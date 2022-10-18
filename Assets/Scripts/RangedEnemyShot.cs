using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemyShot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform BlulletSpawnPoint;

    public float TimeBetweenShots = 0.3333f;
    private float m_timeStamp = 0f;
    GameObject m_player;


    private void Awake()
    {
        m_player = GameObject.Find("Player?");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
         
        if((Time.time >= m_timeStamp)) 
        {
            Fire2();
            m_timeStamp = Time.time + TimeBetweenShots; 
        }
    }

    void Fire2()
    {
        var bullet = (GameObject)Instantiate(bulletPrefab, BlulletSpawnPoint.position, BlulletSpawnPoint.rotation);
        
        //bullet velocity
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;

        //bullet life time
        Destroy(bullet, 2.0f);

    }
     void Update()
    {
         transform.LookAt(m_player.transform);  

    }

}
