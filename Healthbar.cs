using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [Header("HealthBar")]
    public Slider healthbarUI;
    public float MaxHealth;
    public GameObject GameoverMenu = null;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        healthbarUI.maxValue = MaxHealth;
        healthbarUI.value = healthbarUI.maxValue;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }


    public void GiveDamage(Slider Healthbar,int damage_value)
    {
        Healthbar.value -= damage_value;
    }

    public void Die(Animator animator,string NameofDieAnimation)
    {
        //completing animation 
        animator.SetTrigger(NameofDieAnimation);

        //calling the gameover screen
        Time.timeScale = 0;
        GameoverMenu.SetActive(true);

    }
}
