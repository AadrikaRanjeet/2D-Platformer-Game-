using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingblock : MonoBehaviour
{
    private Rigidbody2D rb;
    public AudioSource fall;
    float thrust=1f;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    {
       if( other.gameObject.CompareTag("player"))
        {
            Debug.Log("Hit");
           rb.AddForce(Vector2.down * thrust);
           fall.Play();
           Invoke("Die",0.3f);
        }
    }
     void Die()
     {
        Destroy(gameObject);
     }
}
