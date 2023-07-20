using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Playerdeath : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
   
    [SerializeField] private AudioSource Hit;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        rb=GetComponent<Rigidbody2D>();
    
    }

   private void OnCollisionEnter2D(Collision2D other)
    {
      
      if(other.gameObject.CompareTag("spike"))
      {
         Die();
      }
      if(other.gameObject.CompareTag("Finish"))
      {
        Die();
      }
     
   }
    private void Die()
    {
       Debug.Log("hit");
        anim.SetTrigger("disappear");
       Hit.Play();
       Invoke("Restart",0.38f);

    }
    // this.GetComponent<playerMovement>.enabled=false;
    private void Restart()
    {
      // will reload the current scene 
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
     
           
}
