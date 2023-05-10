using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchCity4 : MonoBehaviour, IPointerDownHandler
{    
    public static bool isClick4 = false;
    public GameObject City4;
    public GameObject City5;
    public GameObject City3;
    public GameObject City2;
    public GameObject City1;
    private GameHalper gameHalper;
    public static int sequenceNumberCity4;
    public int touchCount4;

    void Start()
    {
        gameHalper = FindObjectOfType<GameHalper>(); // Get reference to Player object
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isClick4 = true;
        if (isClick4) { sequenceNumberCity4 = 1; }
        touchCount4 = eventData.pointerId;
        Debug.Log(touchCount4);
        if (isClick4) { gameHalper.SaveCity4(isClick4); }
    }  
}

   

   

