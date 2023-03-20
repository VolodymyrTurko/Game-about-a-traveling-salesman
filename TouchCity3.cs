using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchCity3 : MonoBehaviour, IPointerDownHandler
{
    public float ThirdCityX { get; private set; }
    public float ThirdCityY { get; private set; }
    public static bool isClick3 = false;

    public Text cityСoordinatesX; // Текстове полке що показує актуальні координати вибраного міста
    public Text cityCoordinatesY;
    public GameObject City3;
    public GameObject City4;
    public GameObject City5;
    public GameObject City1;
    public GameObject City2;
    public static TouchCity3 instance;
    //GameHalper gameHalper;
    //ouchCity3 touchCity3;
    public static int sequenceNumberCity3;
    public static bool twoClick = false;
    public int touchCount;

    public void OnPointerDown(PointerEventData eventData)
    {
        isClick3 = true;
        sequenceNumberCity3 = eventData.clickCount;
        if (sequenceNumberCity3 == 1) twoClick = true;
        //if (TouchCity3.sequenceNumberCity3 == 0) { sequenceNumberCity3++; }

        if (TouchCity3.sequenceNumberCity3 == TouchCity2.sequenceNumberCity2) { sequenceNumberCity3++; }
        // якщо зробим різні числа можна буде по різному записувати міста в список
        // а отже і в іншій послідовності їх рахувати
        if (TouchCity3.sequenceNumberCity3 == TouchCity1.sequenceNumberCity1) { sequenceNumberCity3++; }
        if (TouchCity3.sequenceNumberCity3 == TouchCity4.sequenceNumberCity4) { sequenceNumberCity3++; }
        if (TouchCity3.sequenceNumberCity3 == TouchCity5.sequenceNumberCity5) { sequenceNumberCity3++; }
    }
}

   

    /* void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // A touch began, increment the counter
            touchCount++;
            Debug.Log("Touch count: " + touchCount);
        }
    }*/

