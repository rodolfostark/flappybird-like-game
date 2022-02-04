using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaObstaculo : MonoBehaviour
{
    [SerializeField]
    private VariavelCompartilhada Velocidade;
    [SerializeField]
    private float variacaoDaPosicaoY;
    private Vector3 posicaoDoAviao;
    private bool pontuei;
    private Pontuacao pontuacao;
    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }
    private void Start()
    {
        posicaoDoAviao = GameObject.FindObjectOfType<ControlaAviao>().transform.position;
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }
    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.left * Velocidade.valor * Time.deltaTime);
        if(!pontuei && transform.position.x < posicaoDoAviao.x)
        {
            pontuei = true;
            pontuacao.AdicionarPontos();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destruir();
    }
    public void Destruir()
    {
        Destroy(gameObject);
    }
}
