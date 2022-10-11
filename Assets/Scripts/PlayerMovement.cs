using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController m_charCont;

    float horizontalM;
    float verticalM;

    public float playerspeed = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        m_charCont = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        horizontalM = Input.GetAxis("Horizontal");
        verticalM = Input.GetAxis("Vertical");

        Vector3 m_PlayerMovement = new Vector3(horizontalM, 0, verticalM) * playerspeed;

        m_charCont.Move(m_PlayerMovement);

    }
}
