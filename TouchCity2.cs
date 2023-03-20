using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class TouchCity2 : MonoBehaviour, IPointerDownHandler
{
    public float SecondCityX;
    public float SecondCityY;
    public Text cityCoordinatesY;
    public Text cityСoordinatesX;
    public GameObject City2;
    public GameObject City3;
    public GameObject City4;
    public GameObject City5;
    public GameObject City1;
    public static TouchCity2 instance;
    public int touchCount;

    //GameHalper gameHalper;

    //TouchCity2 touchCity2;
    public static int sequenceNumberCity2;
    public static bool twoClick = false;
    public static bool isClick2 = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        isClick2 = true;
        sequenceNumberCity2 = eventData.clickCount;
        //if (TouchCity2.sequenceNumberCity2 == 0) { sequenceNumberCity2++; }

        if (TouchCity2.sequenceNumberCity2 == TouchCity1.sequenceNumberCity1) { sequenceNumberCity2++; }
        // якщо зробим різні числа можна буде по різному записувати міста в список
        // а отже і в іншій послідовності їх рахувати
        if (TouchCity2.sequenceNumberCity2 == TouchCity3.sequenceNumberCity3) { sequenceNumberCity2++; }
        if (TouchCity2.sequenceNumberCity2 == TouchCity4.sequenceNumberCity4) { sequenceNumberCity2++; }
        if (TouchCity2.sequenceNumberCity2 == TouchCity5.sequenceNumberCity5) { sequenceNumberCity2++; }
    }
}

      

     /*void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // A touch began, increment the counter
            touchCount++;
            Debug.Log("Touch count: " + touchCount);
        }
    }

       // if (sequenceNumberCity2 == 1) twoClick = true;
    }*/



