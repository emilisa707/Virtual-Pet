﻿using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class Game
{
    public static void SaveGame(Pet pet)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/saveFile.dat";
        FileStream stream = new FileStream(path, FileMode.Create);
        GameStateData data = new GameStateData(pet);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameStateData LoadGame()
    {
        string path = Application.persistentDataPath + "/saveFile.dat";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            GameStateData data = formatter.Deserialize(stream) as GameStateData;
            return data;

        }
        else
            return null;
    }
}
