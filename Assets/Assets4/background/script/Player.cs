using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
     public float speed;
     public float jumpfo;
    public Text WINTEXT;

     public LayerMask ground;

     private Rigidbody2D rigidBody;
     private Collider2D playerCollider;

     private Animator animator;

    

     private string ENEMY_TAG ="Enemy";
      
     private void OnCollisionEnter2D(Collision2D collision)
     {

         if(collision.gameObject.CompareTag(ENEMY_TAG))
            {
                Destroy(gameObject);
                gameManager.isGameOver = true;
                Time.timeScale = 0;
            }
     }

     private void OnTriggerEnter2D(Collider2D collision)
     {
        if(collision.tag == "win")
        {
            WINTEXT.gameObject.SetActive(true);
        }



         if(collision.CompareTag(ENEMY_TAG))
            {
                Destroy(gameObject);
                gameManager.isGameOver = true;
            Time.timeScale = 0;
            }
     }
     

      public AudioSource deadSound;
      public AudioSource jumpSound;

    
    void Start()
    { 
       rigidBody=transform.GetComponent<Rigidbody2D>();
       playerCollider=GetComponent<Collider2D>();
       animator = GetComponent<Animator>();

    }


    void Update()
    {
        rigidBody.velocity = new Vector2(speed,rigidBody.velocity.y);
       
        bool grounded = Physics2D.IsTouchingLayers(playerCollider, ground);

        if(Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump"))
        {
           if(grounded)
           {
              // Debug.Log("Jump!");
               jumpSound.Play();
               rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpfo); 
           }
        }

        animator.SetBool("Grounded", grounded);


        

    }
}