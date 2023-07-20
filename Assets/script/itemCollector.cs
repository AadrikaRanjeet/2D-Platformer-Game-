using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class itemCollector : MonoBehaviour
{
    private float fruits=0;
    [SerializeField]  Text fruitText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("collectables"))
        {
            Destroy(other.gameObject);
            fruits ++;
            fruitText.text="Fruits:"+fruits;
        }
    }
}
