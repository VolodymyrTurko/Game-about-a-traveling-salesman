using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class TouchCity1 : MonoBehaviour, IPointerDownHandler
{
    public float FirstCityX { get; private set; }
    public float FirstCityY { get; private set; }
    public Text cityСoordinatesX; // Текстове полке що показує актуальні координати вибраного міста
    public Text cityCoordinatesY;
    public GameObject City1;
    public GameObject City2;
    public GameObject City3;
    public GameObject City4;
    public GameObject City5;
    public static TouchCity1 instance;
    public static bool isClick1 = false;
    public static int sequenceNumberCity1; // порядок натискання
    public static bool twoClick = false;
    public int touchCount;
    //GameHalper gameHalper;

    public void OnPointerDown(PointerEventData eventData)
    {
        isClick1 = true;
        sequenceNumberCity1 = eventData.clickCount;
        if (TouchCity1.sequenceNumberCity1 == TouchCity2.sequenceNumberCity2) { sequenceNumberCity1++; } 
        // якщо зробим різні числа можна буде по різному записувати міста в список
        // а отже і в іншій послідовності їх рахувати
        if (TouchCity1.sequenceNumberCity1 == TouchCity3.sequenceNumberCity3) { sequenceNumberCity1++; }
        if (TouchCity1.sequenceNumberCity1 == TouchCity4.sequenceNumberCity4) { sequenceNumberCity1++; }
        if (TouchCity1.sequenceNumberCity1 == TouchCity5.sequenceNumberCity5) { sequenceNumberCity1++; }
    }

        

     void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // A touch began, increment the counter
            touchCount++;
            Debug.Log("Touch count: " + touchCount);
        }
    }

    // if (sequenceNumberCity1 == 1) twoClick = true;  // ???  Додає всюди по два елементи, змінити
    // Коли вибрано місто його додають до лісти.
    //Потім ліста сортується і кожен обєкт з лісти отримує змінну яка використовується для
    //знаходження відстані між містами, тобто ф-ла така сама а об'єкти підставляються щоразу інші.
}


