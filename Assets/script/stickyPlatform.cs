using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickyPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
     {
          if(other.gameObject.name=="Player")
        {
           other.gameObject.transform.SetParent(transform);//setting platform as a parent of player
        }
        
  }
    
   
   private void OnTriggerExit2D(Collider2D other) 
   {
   
     if(other.gameObject.name=="Player")
        {
           other.gameObject.transform.SetParent(null);//removing platform as a parent of player by setting null as parent
        }
  }
   
   }
  

