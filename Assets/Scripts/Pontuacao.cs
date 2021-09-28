using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    private int pontos = 0;
    [SerializeField]
    private Text textoPontucao;
    private AudioSource audioPontuacao;
    private void Awake()
    {
        audioPontuacao = GetComponent<AudioSource>();
    }
    public void AdicionarPontos()
    {
        pontos++;
        textoPontucao.text = pontos.ToString();
        audioPontuacao.Play();
    }
    public void Reiniciar()
    {
        pontos = 0;
        textoPontucao.text = pontos.ToString();
    }
}
