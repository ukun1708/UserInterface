using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Demo : MonoBehaviour
{
    public ItemView button;

    void Start()
    {
        ItemModel model =  GameConfig.StartSer();

        for (int i = 0; i < 100; i++)
        {
            ItemView view = Instantiate(button, transform);

            view.model = model;

            view.UpdateView();
        }
    }
}
