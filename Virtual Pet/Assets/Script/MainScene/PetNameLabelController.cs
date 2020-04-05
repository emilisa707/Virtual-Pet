using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetNameLabelController : MonoBehaviour
{
    Text petNameLabel;
    GameObject namestorage;
    // Start is called before the first frame update
    void Start()
    {
        namestorage = GameObject.FindGameObjectWithTag("nameInput");
        petNameLabel = transform.gameObject.GetComponent<Text>();

        if(namestorage != null)
        {
            petNameLabel.text = namestorage.GetComponent<KeepNameInputValue>().petName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
