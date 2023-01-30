using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    //Vector2 inputVector;
    Vector2 movement;

    //Vector2 newInputVektor;
    Rigidbody2D PlayerRB;
    Animator playerAnim;
    SpriteRenderer playerSR;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        playerSR = GetComponent<SpriteRenderer>();
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        //if(!PlayerController.isDead)


            //transform.Translate(Vector2.right * speed*Time.deltaTime);
            //ManuelMovement();

            // inputVector.x = Input.GetAxisRaw("Horizontal");
            // inputVector.y = Input.GetAxisRaw("Vertical");

            //transform.Translate(inputVector.normalized * speed);
            // transform.Translate(newInputVektor * speed);

            //PlayerRB.velocity = newInputVektor * speed;


            //PlayerRB.AddForce(newInputVektor * speed);

        if (!PlayerController.isDead)
        { 
            if (Mathf.Abs(movement.x)>0f)
            {
                 movement.y = 0;
            }
                
            PlayerRB.velocity = movement * speed;
        }
        else
        {
            PlayerRB.velocity = Vector2.zero;

        }

   
    
    }
            
                
    private void Update()
    {
        SetAnim();

        if(!PlayerController.isDead)
        {
            SetDirection();
        }

        
    }  
    
    void SetAnim() 
        
     {
        if (!PlayerController.isDead)
        {
            if (PlayerRB.velocity != Vector2.zero)
            {
                playerAnim.SetBool("IsRun", true);
            }

            else
            {
                playerAnim.SetBool("IsRun", false);
            }

        }
        else 
        {
            playerAnim.SetBool("IsDead", PlayerController.isDead);
        }


        }
    void SetDirection()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerSR.flipX = true;        
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            playerSR.flipX = false;
        }
     }

    /* void ManuelMovement()
      {
          if(Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
          {
              if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
              {
                  transform.Translate(Vector2.one.normalized * speed);
              }
              else if (Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow))
              {
                  transform.Translate(new Vector2(1,-1).normalized * speed);
              }
              else
              {
                  transform.Translate(Vector2.right * speed);

              }
          }

          else if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
          {
              if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
              {
                  transform.Translate(new Vector2(-1,1).normalized * speed);
              }

              else if ( Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow))
                  {
                  transform.Translate(Vector2.one.normalized * -speed);
                  }
              else 
              {
                  transform.Translate(Vector2.left * speed);
              }
           }

          else if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
          {
              transform.Translate(Vector2.up * speed);
          }
         else if (Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow))
          {
              transform.Translate(Vector2.down * speed);

          }
      }*/

    void OnMovement(InputValue value)
    {
       //newInputVektor = value.Get<Vector2>();
       movement = value.Get<Vector2>();
    }


    }
/*
Vektor2.right= 1, 0
Vektor2.left=  -1, 0
Vektor2.up=    0, 1
Vektor2.down=  0, -1
Vektor2.one=   1, 1
 */
