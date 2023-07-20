/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedown : MonoBehaviour
{
  public float speed=10f;
  public Rigidbody2D rb;
   private void Start() {
    rb=GetComponent<Rigidbody2D>();
   // rb.IsKinematic=true;
   }
    private void OnCollisionEnter2D(Collision2D other) {
         Vector2 move=new Vector2(0,1);
        if(other.gameObject.CompareTag("player"))
        {
            Debug.Log("Hit");
           // rb.IsKinematic=false;
            rb.AddForce(move*speed, ForceMode2D.Impulse);
        }
    }
}
*/