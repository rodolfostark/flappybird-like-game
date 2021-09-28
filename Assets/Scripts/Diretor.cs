using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverBackGround;
    private ControlaAviao aviao;
    private Pontuacao pontuacao;
    private void Start()
    {
        aviao = GameObject.FindObjectOfType<ControlaAviao>();
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        gameOverBackGround.SetActive(true);
    }
    public void ReiniciarJogo()
    {
        gameOverBackGround.SetActive(false);
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
