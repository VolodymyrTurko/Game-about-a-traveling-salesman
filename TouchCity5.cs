using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchCity5 : MonoBehaviour, IPointerDownHandler
{
    public static bool isClick5 = false;
    public GameObject City5;
    public GameObject City4;
    public GameObject City3;
    public GameObject City2;
    public GameObject City1;
    private GameHalper gameHalper;
    public static int sequenceNumberCity5;
    public int touchCount5;
    
    void Start()
    {
        gameHalper = FindObjectOfType<GameHalper>(); // Get reference to Player object
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isClick5 = true;
        if (isClick5) { sequenceNumberCity5 = 1; }
        touchCount5 = eventData.pointerId;
        Debug.Log(touchCount5);
        if (isClick5) { gameHalper.SaveCity5(isClick5); }
    }   
}

   

   
