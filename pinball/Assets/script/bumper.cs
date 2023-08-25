using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;

    public Auudio audioManager;

   
    private Animator animator;
    private void Start()
    {

        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
        {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //animasi
            animator.SetTrigger("hit");

            //playsfx
            audioManager.PlaySFX(collision.transform.position);
        }          
        
    }
}

