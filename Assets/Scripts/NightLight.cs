using UnityEngine;

public class NightLight : MonoBehaviour
{
    City city;
    public Light[] lights;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        city = GameObject.FindGameObjectWithTag("GameController").GetComponent<City>();
    }

    // Update is called once per frame
    void Update()
    {
        if (city.curDayTime < 7f || city.curDayTime > 18f)
        {
            foreach (Light light in lights)
            {
                light.enabled = true;
            }
        }
        else 
        {
            foreach (Light light in lights)
            {
                light.enabled = false;
            }
        }
    }
}
