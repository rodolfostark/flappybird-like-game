using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public int Pontos { get; private set; }
    [SerializeField]
    private Text textoPontucao;
    private AudioSource audioPontuacao;
    private void Awake()
    {
        audioPontuacao = GetComponent<AudioSource>();
    }
    public void AdicionarPontos()
    {
        Pontos++;
        textoPontucao.text = Pontos.ToString();
        audioPontuacao.Play();
    }
    public void Reiniciar()
    {
        Pontos = 0;
        textoPontucao.text = Pontos.ToString();
    }
    public void SalvarRecorde()
    {
        int recorde = PlayerPrefs.GetInt(Tags.Recorde);
        if (Pontos > recorde)
        {
            PlayerPrefs.SetInt(Tags.Recorde, Pontos);
        }
    }
}
