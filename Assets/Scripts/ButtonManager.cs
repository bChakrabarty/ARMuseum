using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    /*
    [SerializeField]
    GameObject modeLbl;

    Lean.Touch.LeanTranslate modelTranslateScript;

    Lean.Touch.LeanScale modelScaleScript;

    Lean.Touch.LeanRotateCustomAxisX modelRotateXScript;

    Lean.Touch.LeanRotateCustomAxisY modelRotateYScript;

    Lean.Touch.LeanRotateCustomAxisZ modelRotateZScript;

    GameObject shell;

    [SerializeField]
    GameObject shellLbl;

    BoxCollider shellColl;

    List<GameObject> texts = new List<GameObject>();

    [SerializeField]
    GameObject annotationPnl;

    [SerializeField]
    GameObject annotationInputText;

    private int textsCounter = 0;

    [SerializeField]
    GameObject nodulePnl;

    [SerializeField]
    GameObject lungs;

    [SerializeField]
    GameObject kidneys;

    [SerializeField]
    GameObject modelSelectPnl;
    */

    [SerializeField]
    GameObject panel;

    [SerializeField]
    GameObject text;

    [SerializeField]
    GameObject image;

    [SerializeField]
    GameObject image2;

    [SerializeField]
    GameObject buton;

    private void Setup()
    {
        /*
        modelSelectPnl.SetActive(false);
        modelTranslateScript = GameObject.FindWithTag("model").GetComponent<Lean.Touch.LeanTranslate>();
        modelScaleScript = GameObject.FindWithTag("model").GetComponent<Lean.Touch.LeanScale>();
        modelRotateXScript = GameObject.FindWithTag("model").GetComponent<Lean.Touch.LeanRotateCustomAxisX>();
        modelRotateYScript = GameObject.FindWithTag("model").GetComponent<Lean.Touch.LeanRotateCustomAxisY>();
        modelRotateZScript = GameObject.FindWithTag("model").GetComponent<Lean.Touch.LeanRotateCustomAxisZ>();
        shell = GameObject.FindWithTag("model");
        shellColl = GameObject.FindWithTag("model").GetComponent<BoxCollider>();
        for (int i = 0; i < 5; i++)
        {
            texts.Add(GameObject.FindWithTag("notes").transform.GetChild(i).gameObject);
            texts[i].SetActive(false);
        }
        */
    }

    private void OnMouseDown()
    {
        panel.SetActive(false);
        text.SetActive(false);
        image.SetActive(false);
        image2.SetActive(false);
        buton.SetActive(false);
    }


    public void Shell()
    {

        //Setup();

        panel.SetActive(false);
        text.SetActive(false);
        image.SetActive(false);
        image2.SetActive(false);
        buton.SetActive(false);

    /*
    if (shell.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled)
    {
        shell.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = false;
        shellColl.enabled = false;
        shellLbl.GetComponent<TMPro.TextMeshProUGUI>().text = "Show shell";
    }
    else
    {
        shell.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        shellColl.enabled = true;
        shellLbl.GetComponent<TMPro.TextMeshProUGUI>().text = "Hide shell";
    }
    */
}

}
