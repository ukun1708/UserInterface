using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{

    public GameObject popPage;

    public void Pop()
    {
        popPage.SetActive(true);
    }

    public void ClosePop()
    {
        popPage.SetActive(false);
    }

    public void AppQuit()
    {
        Application.Quit();        
    }
}
