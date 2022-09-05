using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Attack : MonoBehaviour
{
    [SerializeField] private int Damage_val;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D hit;
        if (hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero))
        {
            string hitted_obj = hit.collider.transform.gameObject.tag;

            if (hitted_obj == "Enemy" && Input.GetMouseButtonDown(0))
            {
                var healthbar_ofenemy = hit.collider.GetComponent<Healthbar>();
                Slider ememy_healthbar = healthbar_ofenemy.healthbarUI;
                healthbar_ofenemy.GiveDamage(ememy_healthbar,Damage_val);
                Debug.Log(healthbar_ofenemy.healthbarUI.value);
                Debug.Log(hitted_obj);
            }
            
        }
    }
    
}