using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class GameHalper : MonoBehaviour, IPointerDownHandler
{
    public Text count;
    public Button Rezult;
    public GameObject City1;
    public GameObject City2;
    public GameObject City3;
    public GameObject City4;
    public GameObject City5;
    //public static GameHalper instance;
    public float distance;



    public void OnPointerDown(PointerEventData eventData)
    // Форіч не треба бо робиться безкінечний цикл
    {
        Vector3 city1position = Camera.main.ScreenToWorldPoint(new Vector3(100f, 100f, 0f)); // City2
        float city1Width = 100f;
        float city1Height = 100f;
        Rect City1Area = new Rect(city1position.x - city1Width / 2f, city1position.y - city1Height / 2f, city1Width, city1Height);
        //Rect City1Area = new Rect(434.6f, 28f, 100f, 100f); // 450.4 - 25.8    434.6   28
        if (City1Area.Contains(Camera.main.ScreenToWorldPoint(Input.mousePosition))) { SaveCity1(TouchCity1.isClick1); }

        Vector3 city2position = Camera.main.ScreenToWorldPoint(new Vector3(100f, 100f, 0f)); // City2
        float city2Width = 100f;
        float city2Height = 100f;
        Rect City2Area = new Rect(city2position.x - city2Width / 2f, city2position.y - city2Height / 2f, city2Width, city2Height);
        if (City2Area.Contains(Camera.main.ScreenToWorldPoint(Input.mousePosition))) { SaveCity2(TouchCity2.isClick2); }

        Vector3 city3position = Camera.main.ScreenToWorldPoint(new Vector3(100f, 100f, 0f)); // City3
        float city3Width = 100f;
        float city3Height = 100f;
        Rect City3Area = new Rect(city3position.x - city3Width / 2f, city3position.y - city3Height / 2f, city3Width, city3Height);
        if (City3Area.Contains(Camera.main.ScreenToWorldPoint(Input.mousePosition))) { SaveCity3(TouchCity3.isClick3); }

        Vector3 city4position = Camera.main.ScreenToWorldPoint(new Vector3(100f, 100f, 0f)); // City4
        float city4Width = 100f;
        float city4Height = 100f;
        Rect City4Area = new Rect(city4position.x - city4Width / 2f, city4position.y - city4Height / 2f, city4Width, city4Height);
        if (City4Area.Contains(Camera.main.ScreenToWorldPoint(Input.mousePosition))) { SaveCity4(TouchCity4.isClick4); }

        Vector3 city5Position = Camera.main.ScreenToWorldPoint(new Vector3(100f, 100f, 0f)); // City5
        float city5Width = 100f;
        float city5Height = 100f;
        Rect City5Area = new Rect(city5Position.x - city5Width / 2f, city5Position.y - city5Height / 2f, city5Width, city5Height);
        if (City5Area.Contains(Camera.main.ScreenToWorldPoint(Input.mousePosition))) { SaveCity5(TouchCity5.isClick5); }

        //if (TouchCity5.sequenceNumberCity5 == 1) { SaveCity5(TouchCity5.isClick5); } - ЗАПАСНИЙ ВАРІАНТ

        //if (TouchCity2.instance.touchCount == 6)
        {
            // SaveCity2(TouchCity2.isClick2);

        }
        //if (TouchCity3.instance.touchCount == 6)
        {
            // SaveCity3(TouchCity3.isClick3);

        }
        //if (TouchCity4.instance.touchCount == 6)
        {
            //  SaveCity4(TouchCity4.isClick4);

        }
        //if (TouchCity5.instance.touchCount == 6)
        {
            //SaveCity5(TouchCity5.isClick5);

        }

        if (Input.touchCount <= 7)
            Debug.Log(touchCities.GetType());


        FindDistancesBetweenObjects();
    }

    public List<GameObject> touchCities = new List<GameObject>();

    public GameObject SaveCity1(bool isClick1)
    {
        if (isClick1)
        {
            touchCities.Add(City1);
            return City1;
        }
        else
        {
            Debug.LogError("Не можу повернути геймобжект. Будь ласка, виберіть геймобжект.");
            return null;
        }
    }

    public GameObject SaveCity2(bool isClick2)
    {
        if (isClick2 == true)
        {
            touchCities.Add(City2);
            return City2;
        }
        else
        {
            Debug.LogError("Не можу повернути геймобжект. Будь ласка, виберіть геймобжект.");
            return null;
        }
    }


    public GameObject SaveCity3(bool isClick3)
    {
        if (isClick3 == true)
        {
            touchCities.Add(City3);
            return City3;
        }
        else
        {
            Debug.LogError("Не можу повернути геймобжект. Будь ласка, виберіть геймобжект.");
            return null;
        }
    }

    public GameObject SaveCity4(bool isClick4)
    {
        if (isClick4 == true)
        {
            touchCities.Add(City4);
            return City4;
        }
        else
        {
            Debug.LogError("Не можу повернути геймобжект. Будь ласка, виберіть геймобжект.");
            return null;
        }
    }

    public GameObject SaveCity5(bool isClick5)
    {
        if (isClick5 == true)
        {
            touchCities.Add(City5);
            return City5;
        }
        else
        {
            Debug.LogError("Не можу повернути геймобжект. Будь ласка, виберіть геймобжект.");
            return null;
        }
    }

    public void FindDistancesBetweenObjects()
    {
        //for (int i = 0; i < touchCities.Count; i++)
        {
            float distance = Vector3.Distance(touchCities[0].transform.position, touchCities[1].transform.position);
            distance += Vector3.Distance(touchCities[1].transform.position, touchCities[2].transform.position);
            distance += Vector3.Distance(touchCities[2].transform.position, touchCities[3].transform.position);
            distance += Vector3.Distance(touchCities[3].transform.position, touchCities[4].transform.position);
            distance += Vector3.Distance(touchCities[4].transform.position, touchCities[0].transform.position);
            count.text = "You traveled " + distance;
        }

    }

}
