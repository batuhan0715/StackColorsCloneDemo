using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float hor;
    float ver;
    public float verSpeed = 4;
    public float horSpeed = 6;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        this.enabled = false;
        StartCoroutine(WaitBeforePlay());
    }

    
    void Update()
    {
        //StartCoroutine(WaitBeforeMove());
        Movement();
        if(this.enabled == true)
        {
            animator.SetBool("isRunning", true);
        }
    }

    void Movement()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horSpeed * hor * Time.deltaTime, 0, verSpeed * Time.deltaTime));
    }

    IEnumerator WaitBeforePlay()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        this.enabled = true;
    }


   // IEnumerator WaitBeforeMove()
    //{
      //  yield return new WaitForSecondsRealtime(2.5f);
        //Movement();
    //}
}
