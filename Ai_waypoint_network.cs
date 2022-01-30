using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//first we tell unity that this is a custom editor script and a type of onother script 
//  so that the unity can access the desired script or to work as required 
[CustomEditor(typeof(AI_waypoint_network))] 


public class NewBehaviourScript : Editor //mentioning editor script 
{
    private void OnSceneGUI() //use to make on scene gui  
    {
        //taking or assigning variables form the desigred script  
        AI_waypoint_network network = (AI_waypoint_network)target;

        //using for loop we check the waypoints and display there name in scene view
        for (int i = 0; i < network.Waypoints.Count; i++)
        {
            if (network.Waypoints != null)
            {

                Handles.Label(network.Waypoints[i].position, "Waypoint " + i.ToString());
            }
        }

        //taking an array of vector3 of all the waypoint gameobjects for furthr uses 
        Vector3[] Linepoints = new Vector3[network.Waypoints.Count + 1];

        //using for loop to go each and every part of the gameobjects to make a line 
        for (int i = 0; i<= network.Waypoints.Count ; i++)
        {
            int index = i != network.Waypoints.Count ? i : 0; 
            if (network.Waypoints[index] != null)
            {
                Linepoints[i] = network.Waypoints[index].position;
            }
            else
            {
                Linepoints[i] = new Vector3(Mathf.Infinity,Mathf.Infinity,Mathf.Infinity); ;
            }
            
        }

        //now displaying the proper line by editor handle methods 
        Handles.color = Color.cyan;
        Handles.DrawPolyLine(Linepoints);
    }

}
