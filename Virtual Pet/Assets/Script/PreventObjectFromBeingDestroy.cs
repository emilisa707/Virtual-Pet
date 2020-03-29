using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventObjectFromBeingDestroy : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
