using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemView : MonoBehaviour
{
    public Image avatarImg;

    public TextMeshProUGUI countSub;

    public TextMeshProUGUI player_Name;

    public TextMeshProUGUI price;

    public Image productImg;

    public TextMeshProUGUI productName;

    public ItemModel model;
    public void UpdateView()
    {
        productName.text = model.productName;

        player_Name.text = model.playerName;

        price.text = model.price;

        countSub.text = model.countSubject;

        StartCoroutine(LoadSpriteFromUrl(avatarImg, model.avatar));

        var sp = Resources.Load<Sprite>(model.productImage);

        productImg.sprite = sp;
    }

    
    IEnumerator LoadSpriteFromUrl(Image image, string url)
    {
        WWW www = new WWW(url);
        yield return www;
        image.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
    }
}
