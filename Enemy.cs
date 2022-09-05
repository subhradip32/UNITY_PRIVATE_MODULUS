using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    [Header("Follow Target")]
    [SerializeField] private float speed;
    [SerializeField] private Transform target;
    [SerializeField] private float MinimumDistance;
    [SerializeField] private Animator Enemy_animator;
    [SerializeField] private string Die_animationName;
    [SerializeField] private bool is_in_Range = false;

    [SerializeField] private Healthbar healtbar;

    private void Start()
    {
        Healthbar healthbar = GetComponent<Healthbar>();
    }


    void Update()
    {
        //Attacking code
        if (is_in_Range)
        {
            Attack_fun();
        }
        else
        {
            Enemy_animator.SetBool("is_walking", false);
        }
    }

    private void FixedUpdate()
    {
        //Die 
        if (healtbar.healthbarUI.value == 0)
        {
            Enemy_animator.SetTrigger(Die_animationName);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            is_in_Range = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        is_in_Range = false;
        
    }

    void Attack_fun()
    {
        if (Vector2.Distance(transform.position, target.position) > MinimumDistance)
        {
            //Animations
            Enemy_animator.SetBool("is_walking", true);

            //Movements 
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            //calculating the rotation for the target 
            if (transform.position.x > target.position.x)
            {
                transform.rotation = new Quaternion(0, 180, 0, 0);
            }
            if (transform.position.x < target.position.x)
            {
                transform.rotation = new Quaternion(0, 0, 0, 0);
            }
        }
        else
        {
            //attack animations
            Enemy_animator.SetTrigger("Attack");
            Enemy_animator.SetBool("is_walking", false);
        }
    }


}
