using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchCity5 : MonoBehaviour, IPointerDownHandler
{
    public float FiveCityX { get; private set; }
    public float FiveCityY { get; private set; }
    public static bool isClick5 = false;

    public Text cityCoordinatesX; 
    public Text cityCoordinatesY;
    public GameObject City5;
    public GameObject City4;
    public GameObject City3;
    public GameObject City2;
    public GameObject City1;
    public static TouchCity5 instance;
    //GameHalper gameHalper;
    //TouchCity5 touchCity5;
    public static int sequenceNumberCity5;
    public static bool twoClick = false;
    public int touchCount;

    public void OnPointerDown(PointerEventData eventData)
    {
            isClick5 = true;
        sequenceNumberCity5 = eventData.clickCount;

        if (sequenceNumberCity5 == 1) twoClick = true;
        //if (TouchCity5.sequenceNumberCity5 == 0) { sequenceNumberCity5++; }

        if (TouchCity5.sequenceNumberCity5 == TouchCity2.sequenceNumberCity2) { sequenceNumberCity5++; }
        // якщо зробим різні числа можна буде по різному записувати міста в список
        // а отже і в іншій послідовності їх рахувати
        if (TouchCity5.sequenceNumberCity5 == TouchCity3.sequenceNumberCity3) { sequenceNumberCity5++; }
        if (TouchCity5.sequenceNumberCity5 == TouchCity4.sequenceNumberCity4) { sequenceNumberCity5++; }
        if (TouchCity5.sequenceNumberCity5 == TouchCity1.sequenceNumberCity1) { sequenceNumberCity5++; }
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
