using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlaceholderOnClick : MonoBehaviour, IPointerDownHandler {
    public void OnPointerDown(PointerEventData eventData)
    {
        gameObject.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "";
    }
}
