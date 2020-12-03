using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConfig : MonoBehaviour
{
    public static ItemModel StartSer()
	{
		ItemModel model;

		string path = Application.streamingAssetsPath + "/item_00.json";

		UnityEngine.Networking.UnityWebRequest www = UnityEngine.Networking.UnityWebRequest.Get(path);

		www.SendWebRequest();

		while (!www.isDone)
		{

		}

		string text = www.downloadHandler.text;

		model = JsonUtility.FromJson<ItemModel>(text);

		return model;
	}
}
