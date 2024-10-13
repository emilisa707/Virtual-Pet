using System;

[Serializable]
public class GameStateData
{
    public string petName;
    public int energyLevel, happinessLevel;
    public DateTime lastTimeLogOut;

    public GameStateData(Pet pet)
    {
        petName = pet.petName;
        energyLevel = pet.energy;
        happinessLevel = pet.happiness;
        lastTimeLogOut = pet.time;
    }
}