using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System;
using System.Linq;

public class GameHalper : MonoBehaviour, IPointerDownHandler
{
    public Text count;
    public Text lastRezult;
    public Text bestRezult;
    public Text LivesLeft;

    public Button Rezult;
    public GameObject City1;
    public GameObject City2;
    public GameObject City3;
    public GameObject City4;
    public GameObject City5;
    public float distance;
    public TryAgain tryAgain;
    public int loadScene;

    public void OnPointerDown(PointerEventData eventData)
    {     
        FindDistancesBetweenObjects();     
    }

    public List<GameObject> touchCities = new List<GameObject>();

    public List<float> distances = new List<float>(); // ліст результатів

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
        {
            float distance = Vector3.Distance(touchCities[0].transform.position, touchCities[1].transform.position);
            distance += Vector3.Distance(touchCities[1].transform.position, touchCities[2].transform.position);
            distance += Vector3.Distance(touchCities[2].transform.position, touchCities[3].transform.position);
            distance += Vector3.Distance(touchCities[3].transform.position, touchCities[4].transform.position);
            distance += Vector3.Distance(touchCities[4].transform.position, touchCities[0].transform.position);
            count.text = "You traveled " + distance;
           
            distances.Add(distance);
            distances.Sort();
            bestRezult.text = "Best " + distances.Last(); // зробити зберігання інфи між іграми і перевірку який результат більший
            PlayerPrefs.SetString("highScore", bestRezult.text);
            bestRezult.text = PlayerPrefs.GetString("highScore");
            PlayerPrefs.SetString("lastRezult", lastRezult.text);
            lastRezult.text = "Last " + distance.ToString(); // зробити щоб ост рез змінювався          
            loadScene--;
            LivesLeft.text = loadScene.ToString();
        }
    }
}
