using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    void HandleMovement()
    {
        if(isLocalPlayer)
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            Vector3 movement = new Vector3(horizontal * 0.1f,
             vertical*0.1f, 0);
            transform.position = transform.position + movement;
        }
    }

    void Update()
    {
        HandleMovement();
    }

}
