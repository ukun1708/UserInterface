using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{

    public GameObject scrollContent;

    private Coroutine coroutine;

    public void scrollVerticalPlus()
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }

        coroutine = StartCoroutine(ScrollingVerticalCor(1000f));
    }

    public void scrollVerticalMinus()
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }

        coroutine = StartCoroutine(ScrollingVerticalCor(-1000f));
    }

    IEnumerator ScrollingVerticalCor(float delta)
    {
        RectTransform rectTransform = scrollContent.GetComponent<RectTransform>();

        float time = 0f;

        float timer = 1f;

        float targetHeight = rectTransform.anchoredPosition.y + delta;

        if (targetHeight < 0f)
        {
            targetHeight = 0f;
        }

        if (targetHeight > rectTransform.sizeDelta.y)
        {
            targetHeight = rectTransform.sizeDelta.y;
        }

        while (time < timer)
        {
            time += Time.deltaTime;

            rectTransform.anchoredPosition = new Vector2(0f, Mathf.Lerp(rectTransform.anchoredPosition.y, targetHeight, time));

            yield return null;
        }
    }
}
