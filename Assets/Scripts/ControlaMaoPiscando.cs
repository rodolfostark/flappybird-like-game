using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaMaoPiscando : MonoBehaviour
{
    private SpriteRenderer imagem;
    private void Awake()
    {
        imagem = GetComponent<SpriteRenderer>();
        
    }
    private void Update()
    {
        if(Input.GetButtonDown(Tags.BotaoEsquerdoDoMouse))
        {
            Desaparecer();
        }        
    }

    private void Desaparecer()
    {
        imagem.enabled = false;
    }
}
