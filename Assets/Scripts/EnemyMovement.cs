using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float EnemySpeed;
    GameObject m_player;


    private void Awake()
    {
        m_player = GameObject.Find("Player?");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 LocalPosition = m_player.transform.position - transform.position;
        LocalPosition = LocalPosition.normalized;
        transform.Translate(LocalPosition.x * Time.deltaTime * EnemySpeed, 
                            0f, 
                            LocalPosition.z * Time.deltaTime * EnemySpeed, Space.World);
        transform.LookAt(m_player.transform);  

    }
}
