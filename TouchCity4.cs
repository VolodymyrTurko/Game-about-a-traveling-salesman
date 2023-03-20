using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchCity4 : MonoBehaviour, IPointerDownHandler
{    
    public float FourCityX { get; private set; }
    public float FourCityY { get; private set; }
    public static bool isClick4 = false;

    public Text cityCoordinatesX; 
    public Text cityCoordinatesY;
    public GameObject City4;
    public GameObject City5;
    public GameObject City3;
    public GameObject City2;
    public GameObject City1;
    public static TouchCity4 instance;
    //GameHalper gameHalper;
    //readonly TouchCity4 touchCity4;
    public static int sequenceNumberCity4;
    public static bool twoClick = false;
    public int touchCount;

    public void OnPointerDown(PointerEventData eventData)
    {
        isClick4 = true;
        sequenceNumberCity4 = eventData.clickCount;

        if (sequenceNumberCity4 == 1) twoClick = true;
        // if (TouchCity4.sequenceNumberCity4 == 0) { sequenceNumberCity4++; }

        if (sequenceNumberCity4 == TouchCity2.sequenceNumberCity2) { sequenceNumberCity4++; }
        // якщо зробим різні числа можна буде по різному записувати міста в список
        // а отже і в іншій послідовності їх рахувати
        if (sequenceNumberCity4 == TouchCity3.sequenceNumberCity3) { sequenceNumberCity4++; }
        if (sequenceNumberCity4 == TouchCity1.sequenceNumberCity1) { sequenceNumberCity4++; }
        if (sequenceNumberCity4 == TouchCity5.sequenceNumberCity5) { sequenceNumberCity4++; }
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
}*/
