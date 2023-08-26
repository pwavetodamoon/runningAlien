using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    logicScript logic;
    public Rigidbody2D rb;
    public  float PowerJump;
    public Animator anim;

    private bool isGrounded = false;
    private bool PlayerStillAlive = true;
    int jumpCount = 0; // đếm số lần nhảy
    // Start is called before the first frame update
    private void Awake()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
        PlayerInput playerInputAction = new PlayerInput();
        playerInputAction.Enable();
        playerInputAction.Player.Jump.started += Jump;

    }

    private void Jump(InputAction.CallbackContext context)
    {
        if(context.started && isGrounded && jumpCount < 2 && PlayerStillAlive)
        {
            Debug.Log(context);
            rb.velocity = Vector2.up * PowerJump;
            anim.SetTrigger("jump");
            jumpCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // Kiểm tra va chạm mặt đất
    {
        if (collision.gameObject.tag == ("ground")) // nếu đúng thì:
        {
            isGrounded = true;
            jumpCount = 0;
        }   
        if ( collision.gameObject.tag == ("enemy"))
        {
             PlayerStillAlive = false;
             logic.GameOver();
        }    
    }
}

