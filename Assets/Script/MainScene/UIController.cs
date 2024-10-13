using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    Pet pet;
    PetBehavior behavior;

    Slider energySlider;
    Slider happinessSlider;

    // Start is called before the first frame update
    void Awake()
    {
        energySlider = GameObject.FindGameObjectWithTag("energySlider").GetComponent<Slider>();
        happinessSlider = GameObject.FindGameObjectWithTag("happinessSlider").GetComponent<Slider>();

        pet = FindObjectOfType<Pet>();
        behavior = FindObjectOfType<PetBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        energySlider.value = pet.energy;
        happinessSlider.value = pet.happiness;
    }

    public void EatButtonAction()
    {
        pet.energy += 50;
        behavior.SetAnimationState("eat");
    }

    public void BathButtonAction()
    {
        pet.happiness += 20;
        behavior.SetAnimationState("bath");
    }

    public void PlayButtonAction()
    {
        pet.happiness += 10;
        behavior.SetAnimationState("play");
    }

    public void PatButtonAction()
    {
        pet.happiness += 5;
        behavior.SetAnimationState("pat");
    }

    public void MedichineButtonAction()
    {
        pet.energy += 80;

    }

    public void SleepButtonAction()
    {
        pet.energy += 30;
        behavior.SetAnimationState("sleep");
    }
}
