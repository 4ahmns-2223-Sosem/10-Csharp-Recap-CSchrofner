using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSchleife : MonoBehaviour
{
    [SerializeField] Arrays kartenScript;
    [SerializeField] Verzweigung[] farbAuswahl;
    public void AufdeckLoop()
    {

        for (int i = 0; i < kartenScript.kartenArray.Length; i++)
        {
            kartenScript.kartenArray[i].sprite = farbAuswahl[i].FarbeRandom();
        }
    }

}
