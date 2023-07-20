using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sprite;
    public float moveSpeed;
    public float jumpSpeed;
    private bool IsJumping;
    public float gravityScale =10f;
    public float fallgravityScale = 40f; 
    private float jumpcount=0f;
    private BoxCollider2D collide;
    [SerializeField] private LayerMask jumpableGround ;
    [SerializeField] private AudioSource walk; 
     [SerializeField] private AudioSource jump; 
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
        sprite=GetComponent<SpriteRenderer>();
        IsJumping =false;
        collide=GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        AnimationFunc();
    }
    
   public void AnimationFunc()
     {
           float xdir=Input.GetAxis("Horizontal");
        float ydir=Input.GetAxis("Vertical");
        Vector3 movement =new Vector3(xdir,ydir,0);
        if(Input.GetAxis("Horizontal")>0)
        {
             sprite.flipX = false;
              walk.Play();
             anim.SetBool("run", true);
            transform.Translate(movement*moveSpeed*Time.deltaTime);
            
        }
         if(Input.GetAxis("Horizontal")<0)
        {
            sprite.flipX = true;
            walk.Play();
             anim.SetBool("run", true);
            transform.Translate(movement*moveSpeed*Time.deltaTime);
        }
        if(Input.GetAxis("Horizontal")==0)
        {
             anim.SetBool("run", false);
        }
       if(Input.GetKeyDown(KeyCode.Space)&& IsGrounded())
       {
        //Debug.Log(IsJumping);
        anim.SetTrigger("jump");
        // jumpcount++;
        rb.AddForce(Vector2.up * jumpSpeed,ForceMode2D.Impulse);
        jump.Play();
       }
       //double jump
       /* if(jumpcount>0)
       {
        anim.SetTrigger("doublejump");
        jumpcount=0;
       }*/

       //for faster fall style jump 
        if(rb.velocity.y <0)
        {
          rb.gravityScale =gravityScale;
          
        }
     }
      /* private void OnCollisionEnter2D(Collision2D other)
        {
        if(other.gameObject.CompareTag("box"))
        {
           IsJumping=false;
        }
       }
       private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("box"))
        {
            IsJumping=true;
        }
       }*/
          private bool IsGrounded()
          {
            return Physics2D.BoxCast(collide.bounds.center, collide.bounds.size,0f,Vector2.down ,.1f,jumpableGround);   
          }
     }

