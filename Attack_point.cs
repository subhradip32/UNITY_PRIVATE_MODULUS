using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_point : MonoBehaviour
{
    
    public Healthbar healthbar; //player
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            healthbar.GiveDamage(healthbar.healthbarUI, 10);
        }
    }
}
