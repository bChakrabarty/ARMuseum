using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodule : MonoBehaviour
{
    [SerializeField]
    GameObject panel;
    [SerializeField]
    GameObject text;
    [SerializeField]
    GameObject image;
    [SerializeField]
    GameObject buton;
    [SerializeField]
    GameObject info;



    private void OnMouseDown()
    {
        panel.SetActive(true);
        buton.SetActive(true);
        info.GetComponent<TMPro.TextMeshProUGUI>().text=text.GetComponent<TMPro.TextMeshProUGUI>().text;
        //noduleGfx.GetComponent<SpriteRenderer>().sprite= image.GetComponent<UnityEngine.UI.Image>().sprite;
        info.SetActive(true);
        image.SetActive(true);
    }
}
