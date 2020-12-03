using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Clock : MonoBehaviour
{
    TextMeshProUGUI textMesh;

    float hours = 23, minut = 59, second = 00;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    
    void Update()
    {
        textMesh.text = hours.ToString("F0") + ":" + minut.ToString("F0") + ":" + second.ToString("F0");

        second += Time.deltaTime;

        if (second > 59f)
        {
            minut += 1f;

            second = 0f;
        }
        if (minut > 59f)
        {
            hours += 1f;

            minut = 0f;

            second = 0f;
        }
        if (hours > 23f)
        {
            hours = 0f;

            minut = 0f;

            second = 0f;
        }
    }
}
