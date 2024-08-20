using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NPC_Trigger : MonoBehaviour
{

    public GameObject gameCanvas;
    public GameObject NPCanvasText;
    public string npcTextToShow;

    private void Start()
    {
        gameCanvas = GameObject.Find("Canvas");
        NPCanvasText = gameCanvas.transform.GetChild(0).transform.gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            npcTextToShow = "OLÁ, EU SOU UM TRIGGER. NÃO ENTRE NA CASA!";
            NPCanvasText.GetComponent<TextMeshProUGUI>().text = npcTextToShow;
            NPCanvasText.SetActive(true);

        }

    }


    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            NPCanvasText.SetActive(false);

        }



    }




}
