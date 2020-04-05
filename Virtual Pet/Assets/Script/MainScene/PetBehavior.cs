using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetBehavior : MonoBehaviour
{
    Pet pet;
    Animator animator;

    // Start is called before the first frame update
    void Awake()
    {
        pet = FindObjectOfType<Pet>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pet.happiness < 40 && pet.happiness > 0)
        {
            animator.SetBool("isSad", true);
            animator.SetBool("isSick", false);
        }

        else if (pet.happiness == 0 || pet.energy == 0)
        {
            animator.SetBool("isSick", true);
            animator.SetBool("isSad", false);
        }

        else
        {

            animator.SetBool("isSad", false);
            animator.SetBool("isSick", false);
        }
    }

    public void SetAnimationState(string state)
    {
        switch(state)
        {
            case "eat":
                animator.SetTrigger("isEating");
                break;

            case "play":
                animator.SetTrigger("isPlaying");
                break;

            case "bath":
                animator.SetTrigger("isBathing");
                break;

            case "sleep":
                animator.SetTrigger("isSleeping");
                break;

            case "pat":
                animator.SetTrigger("isPating");
                break;

            default:
                break;
        }
    }
}
