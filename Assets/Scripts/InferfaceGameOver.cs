using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InferfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    [SerializeField]
    private Text valorRecorde;
    public void MostrarInterface()
    {
        AtualizarInterfaceGrafica();
        imagemGameOver.SetActive(true);
    }
    public void EsconderInterface() 
    {
        imagemGameOver.SetActive(false);
    }
    private void AtualizarInterfaceGrafica() 
    {
        int recorde = PlayerPrefs.GetInt(Tags.Recorde);
        valorRecorde.text = recorde.ToString();
    }
}
