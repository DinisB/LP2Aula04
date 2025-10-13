using UnityEngine;
using System.Collections;


public class GameObject : MonoBehaviour
{
    int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Hello());
        StartCoroutine(Hater());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Hello()
    {
        while (true)
        {
            Debug.Log("Hello");
            yield return new WaitForSeconds(4);
        }

    }

    IEnumerator Hater()
    {
        while (true)
        {
            Debug.Log(count);
            count++;
            yield return new WaitForSeconds(1f);
            if (count == 30)
            {
                StopCoroutine(Hello());
            }
        }
    }
}
