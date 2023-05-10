using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class TouchCity2 : MonoBehaviour, IPointerDownHandler
{
    public GameObject City2;
    public GameObject City3;
    public GameObject City4;
    public GameObject City5;
    public GameObject City1;
    public int touchCount2;
    private GameHalper gameHalper;
    public static int sequenceNumberCity2;
    public static bool isClick2 = false;

    void Start()
    {
        gameHalper = FindObjectOfType<GameHalper>(); // Get reference to Player object
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isClick2 = true;
        if (isClick2) { sequenceNumberCity2 = 1; }
        touchCount2 = eventData.pointerId;
        Debug.Log(touchCount2);
        if (isClick2) { gameHalper.SaveCity2(isClick2); }
    }
}


      

   



