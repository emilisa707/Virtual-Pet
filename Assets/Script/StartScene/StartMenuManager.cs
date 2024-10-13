using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class StartMenuManager : MonoBehaviour
{
    public GameObject flashText;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FlashTheText", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            string path = Application.persistentDataPath + "/saveFile.dat";
            if (File.Exists(path))
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    void FlashTheText()
    {
        if (flashText.activeInHierarchy)
            flashText.SetActive(false);
        else
            flashText.SetActive(true);
    }
}
