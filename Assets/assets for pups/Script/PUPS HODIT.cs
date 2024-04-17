using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pupshodit : MonoBehaviour
{
    public Animator animator;
    Rigidbody2D rb2;
    private bool dontrun = false;
    public float vicet;
    public Slider slider;
    private bool IsStamina = false;
    public float uscorilca = 1.5f;
    public bool levo;
    public bool pravo;
    public bool phase;
    public bool popa;
    public float runspeed = 10f;
    private Vector2 napravlenie;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        napravlenie.x = Input.GetAxisRaw("Horizontal");
        napravlenie.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.LeftShift)) 
        { 
            IsStamina = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            IsStamina = false;
        }

        if (napravlenie.x > 0f)
        {
            animator.SetBool("pravo", pravo = true);
            animator.SetBool("levo", levo = false);
            animator.SetBool("popa", popa = false);
            animator.SetBool("phase", phase = false);
        }
        else if(napravlenie.x < 0f)
        {
            animator.SetBool("pravo", pravo = false);
            animator.SetBool("levo", levo = true);
            animator.SetBool("popa", popa = false);
            animator.SetBool("phase", phase = false);
        }

        if (napravlenie.y > 0f)
        {
            animator.SetBool("popa", popa = true);
            animator.SetBool("phase", phase = false);
            animator.SetBool("pravo", pravo = false);
            animator.SetBool("levo", levo = false);
        }
        else if (napravlenie.y < 0f)
        {
            animator.SetBool("popa", popa = false);
            animator.SetBool("phase", phase = true);
            animator.SetBool("pravo", pravo = false);
            animator.SetBool("levo", levo = false);
        } 

        animator.SetFloat("horizontal", napravlenie.x);
        animator.SetFloat("vertical ", napravlenie.y);
        animator.SetFloat("speed", napravlenie.sqrMagnitude);
    }

    private void FixedUpdate()

    {
        if (Input.GetKey(KeyCode.LeftShift) && dontrun == false)
        {
            rb2.velocity = new Vector2(napravlenie.x, napravlenie.y).normalized * runspeed * uscorilca;
            Debug.Log("IAM FAST");                       
        }        
        else
        {
            rb2.velocity = new Vector2(napravlenie.x, napravlenie.y).normalized * runspeed;
        }

        if (IsStamina == true)
        {
            slider.value -= vicet;
            if (slider.value == 0f)
            {
                dontrun = true;
                
            }            
        }

        else if(IsStamina == false )
        {
            if(slider.value < 100f)
            {
                slider.value += 0.05f;
                if (slider.value >= 1f)
                {
                    dontrun = false;
                }
            }            
        }
    }
}
