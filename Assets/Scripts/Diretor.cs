using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    private ControlaAviao aviao;
    private Pontuacao pontuacao;
    private InferfaceGameOver interfaceGameOver;
    private void Start()
    {
        aviao = GameObject.FindObjectOfType<ControlaAviao>();
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
        interfaceGameOver = GameObject.FindObjectOfType<InferfaceGameOver>();
    }
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        pontuacao.SalvarRecorde();
        interfaceGameOver.MostrarInterface();
    }
    public void ReiniciarJogo()
    {
        interfaceGameOver.EsconderInterface();
        Time.timeScale = 1;
        aviao.Reiniciar();
        DestruirObstaculos();
        pontuacao.Reiniciar();
        
    }
    private void DestruirObstaculos()
    {
        ControlaObstaculo[] obstaculos = GameObject.FindObjectsOfType<ControlaObstaculo>();
        foreach(ControlaObstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
