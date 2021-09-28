using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaGeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerarObstaculos;
    private float cronometroRegressivoDeGeracao;
    [SerializeField]
    private GameObject manualDeInstrucoes;

    private void Awake()
    {
        cronometroRegressivoDeGeracao = tempoParaGerarObstaculos;
    }

    // Update is called once per frame
    void Update()
    {
        cronometroRegressivoDeGeracao -= Time.deltaTime;
        if(cronometroRegressivoDeGeracao <= 0)
        {
            GameObject.Instantiate(manualDeInstrucoes, transform.position, Quaternion.identity);
            cronometroRegressivoDeGeracao = tempoParaGerarObstaculos;
        }
    }
}
