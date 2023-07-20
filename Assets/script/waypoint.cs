using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints; //array of gameobject -waypoint
    private int currentwaypointIndex=0; //keeping track of the waypoint we are currently on

    public float speed = 2f;
    void Update()
    {
        //vector2.Distance calculates distance between 2 vectors 
        if(Vector2.Distance(waypoints[currentwaypointIndex].transform.position,transform.position)<0.1f) //if the current waypoint and platform has a dist of 0.1 btw them 
        {
             currentwaypointIndex ++;
             if(currentwaypointIndex >=waypoints.Length)
             {
                currentwaypointIndex =0;
             }     
        }
        transform.position =Vector2.MoveTowards(transform.position,waypoints[currentwaypointIndex].transform.position,speed*Time.deltaTime);
    }
}
