using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchCity3 : MonoBehaviour, IPointerDownHandler
{
    public static bool isClick3 = false;
    public GameObject City3;
    public GameObject City4;
    public GameObject City5;
    public GameObject City1;
    public GameObject City2;
    private GameHalper gameHalper;
    public static int sequenceNumberCity3;
    public int touchCount3;

    void Start()
    {
        gameHalper = FindObjectOfType<GameHalper>(); // Get reference to Player object
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isClick3 = true;
        if (isClick3) { sequenceNumberCity3 = 1; }
        touchCount3 = eventData.pointerId;
        Debug.Log(touchCount3);
        if (isClick3) { gameHalper.SaveCity3(isClick3); }
    }   
}

   

  
