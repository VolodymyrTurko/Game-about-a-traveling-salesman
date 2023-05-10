using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class TouchCity1 : MonoBehaviour, IPointerDownHandler
{
    public GameObject City1;
    public GameObject City2;
    public GameObject City3;
    public GameObject City4;
    public GameObject City5;
    
    public static bool isClick1 = false;
    public static int sequenceNumberCity1; // порядок натискання
    public static bool twoClick = false;
    public int touchCount1;
   
    private GameHalper gameHalper;
   
    void Start()
    {
        gameHalper = FindObjectOfType<GameHalper>(); // Get reference to Player object
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isClick1 = true;
        if (isClick1) { sequenceNumberCity1 = 1; }
        touchCount1 = eventData.pointerId;
        Debug.Log(touchCount1);
        if (isClick1) { gameHalper.SaveCity1(isClick1); }
    }
    
}


