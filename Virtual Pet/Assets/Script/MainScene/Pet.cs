using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Pet : MonoBehaviour
{
    GameObject namestorage;

    DateTime energyTimer, happinessTimer, newEnergyTimer, newHappinessTimer;
    int energyDelay = 5;
    int happinessDelay = 1;

    [Range(0, 100)] public int energy;
    [Range(0, 100)] public int happiness;

    public string petName;
    public DateTime time;
    public DateTime date;

    // Start is called before the first frame update
    void Awake()
    {
        string path = Application.persistentDataPath + "/saveFile.dat";

        if (File.Exists(path))
        {
            GameStateData data = Game.LoadGame();
            petName = data.petName;
            energy = data.energyLevel;
            happiness = data.happinessLevel;

            energyTimer = happinessTimer = data.lastTimeLogOut;

        }
        else
        {
            namestorage = GameObject.FindGameObjectWithTag("nameInput");
            petName = namestorage.GetComponent<KeepNameInputValue>().petName;

            energy += 100;
            happiness += 100;

            energyTimer = happinessTimer = time;
        }
    }

    // Update is called once per frame
    void Update()
    {
        time = newEnergyTimer = newHappinessTimer = DateTime.Now;

        Energy();
        Happiness();

        if(energy >= 100)
        {
            energy = 100;
        }
        else if(energy <= 0)
        {
            energy = 0;
        }

        if (happiness >= 100)
        {
            happiness = 100;
        }
        else if (happiness <= 0)
        {
            happiness = 0;
        }

    }

    void Energy()
    {
        TimeSpan energyTimerSpan = newEnergyTimer - energyTimer;
        if (energyTimerSpan.TotalMinutes >= energyDelay)
        {
            energy -= (int)energyTimerSpan.TotalMinutes / energyDelay;
            energyTimer = newEnergyTimer;
        }
    }

    void Happiness()
    {
        TimeSpan happinessTimerSpan = newHappinessTimer - happinessTimer;
        if (happinessTimerSpan.TotalMinutes >= happinessDelay)
        {
            happiness -= (int)happinessTimerSpan.TotalMinutes / happinessDelay;
            happinessTimer = newHappinessTimer;
        }
    }

    private void OnApplicationQuit()
    {
        Game.SaveGame(this);
    }
}
