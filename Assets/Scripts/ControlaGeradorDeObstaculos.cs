using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaGeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerarObstaculosFacil;
    [SerializeField]
    private float tempoParaGerarObstaculosDificil;
    private float cronometroRegressivoDeGeracao;
    [SerializeField]
    private GameObject manualDeInstrucoes;
    private ControleDeDificuldade controleDeDificuldade;
    private void Awake()
    {
        cronometroRegressivoDeGeracao = tempoParaGerarObstaculosFacil;
    }
    private void Start()
    {
        controleDeDificuldade = GameObject.FindObjectOfType<ControleDeDificuldade>();
    }
    // Update is called once per frame
    void Update()
    {
        cronometroRegressivoDeGeracao -= Time.deltaTime;
        if(cronometroRegressivoDeGeracao <= 0)
        {
            GameObject.Instantiate(manualDeInstrucoes, transform.position, Quaternion.identity);
            cronometroRegressivoDeGeracao = Mathf.Lerp(tempoParaGerarObstaculosFacil, tempoParaGerarObstaculosDificil, controleDeDificuldade.Dificuldade);
        }
    }
}
