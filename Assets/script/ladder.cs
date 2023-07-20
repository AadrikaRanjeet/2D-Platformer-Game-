/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{
   private float vertical;
   private bool isClimbing;
   private bool isLadder;
   private float speed=4f;
   [SerializeField] private Rigidbody2D rb;
   


    void Update()
    {
        vertical=Input.GetAxis("Vertical");
        if(isLadder && Mathf.Abs(vertical)<0f)
        {
            isClimbing=true;
            rb.gravityScale=12f;
        }
        else{
            rb.gravityScale=9.81f;
        }
    }
    private void FixedUpdate() {
        rb.gravityScale=0f;
        rb.velocity=new Vector2(rb.velocity.x,vertical*speed);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("ladder"))
        {
            isLadder=true;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
         if(other.CompareTag("ladder"))
        {
            isLadder=false;
            isClimbing=false;
        }
    }
}
*/