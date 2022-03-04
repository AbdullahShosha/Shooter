using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float Xdir, Zdir, MovementSpeed = 10, Gravity = -15,jumpForce = 10;
    Vector3 Move, freeFall;
    bool IsGrounded = true;
    


    // Update is called once per frame
    void Update()
    {
        //he can just only if he is Grounded onstead of collider check
        if (transform.position.y < 2.1f)
            IsGrounded = true;


        if (IsGrounded && freeFall.y == 0)
            freeFall.y = 0;
        
        Xdir = Input.GetAxis("Horizontal");
        Zdir = Input.GetAxis("Vertical");

        Move = transform.right * Xdir + transform.forward * Zdir;
        if (Input.GetKey(KeyCode.LeftShift))
            gameObject.GetComponent<CharacterController>().Move(Move * Time.deltaTime * MovementSpeed * 1.5f);
        else 
            gameObject.GetComponent<CharacterController>().Move(Move * Time.deltaTime  * MovementSpeed);

        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            freeFall.y = jumpForce;
            IsGrounded = false;
        }
        freeFall.y += Gravity * Time.deltaTime;
        gameObject.GetComponent<CharacterController>().Move(freeFall * Time.deltaTime);
    }

}
