using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AI_waypoint_network : MonoBehaviour
{
    //Enum is eumerator setting the values publicly to excess with other c# scripts 
    public enum Pathdisplaymode { Connerction, Path, None }; 

    //Initialising the enum value as default value 
    public Pathdisplaymode display_mode = Pathdisplaymode.None;
    
    //taking all the arguments for further calculations 
    public List<Transform> Waypoints = new List<Transform>();
    
}
