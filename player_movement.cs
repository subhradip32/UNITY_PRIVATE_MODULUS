using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    [Header("Player Movement")]
    [SerializeField] Transform player_gf;
    [SerializeField] Rigidbody2D Player_rb;
    [SerializeField] Animator animator_;
    [SerializeField]private float MovementSpeed = 5f;
    [Header("Die Properties")]
    [SerializeField] private Healthbar healthbar;
    [SerializeField] private string Dieanimation_name;
    



    // Start is called before the first frame update
    void Start()
    {
        player_gf = GetComponent<Transform>();
        Player_rb = GetComponent<Rigidbody2D>();
        animator_ = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Movement
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement_vector = new Vector2(x,y) * MovementSpeed;
        Player_rb.velocity = movement_vector;

        //Rotating the player 
        if (x > 0)
        {
            player_gf.rotation = new Quaternion(0,0,0,0);
        }
        if (x < 0)
        {
            player_gf.rotation = new Quaternion(0, 180, 0, 0);
        }

        
       
        //Die 
        if(healthbar.healthbarUI.value == 0)
        {
            healthbar.Die(animator_, Dieanimation_name);
        }

        
    }
    
}
