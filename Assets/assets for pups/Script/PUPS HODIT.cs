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
    public AudioSource Run, Went, breath;
    private bool BEJIT = false, HODI = false;
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
    
    
        if (Input.GetKey(KeyCode.LeftShift) && dontrun == false)
        {
            rb2.velocity = new Vector2(napravlenie.x, napravlenie.y).normalized * runspeed * uscorilca;
            //BEJIT = true; HODI = false;

        }        
        else
        {
            rb2.velocity = new Vector2(napravlenie.x, napravlenie.y).normalized * runspeed;

            //BEJIT = false; HODI = true;
        }

        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && BEJIT != true)
            {
            if (HODI == false)
            {
                HODI = true;
                Went.Play();
                
            }
            
         }
        else if (HODI != false) 
        { 
            HODI = false;
            Went.Stop();
        }
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && Input.GetKey(KeyCode.LeftShift))
        {
            if (BEJIT == false)
            {
                BEJIT = true;
                Run.Play();

            }

        }
        else if (BEJIT != false)
        {
            BEJIT = false;
            Run.Stop();
        }
        // if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        //{
        //    BEJIT = false; HODI = true;
        //}
        // else if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)) && Input.GetKeyDown(KeyCode.LeftShift))
        //{
        //    BEJIT = true; HODI = false;
        //}        
        //if (!Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.A) && !Input.GetKeyDown(KeyCode.S) && !Input.GetKeyDown(KeyCode.D))
        //{
        //    BEJIT = false; HODI = false;
        //}


        //if (!BEJIT) 
        //{
        //    Run.Stop();
        //}
        //else
        //{
        //    Run.Play();
        //}
        //if (!HODI)
        //{
        //    Went.Stop();
        //}
        //else
        //{
        //    Went.Play();
        //}

        if (IsStamina == true)
        {
            slider.value -= vicet;
            if (slider.value == 0f)
            {
                dontrun = true;
                breath.Play();
            }            
        }

        else if(IsStamina == false )
        {
            if(slider.value < 100f)
            {
                slider.value += 0.05f;
                if (slider.value >= 99f)
                {
                    dontrun = false;
                }
            }            
        }
        
    }
}
