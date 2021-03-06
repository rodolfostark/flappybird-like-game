using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaAviao : MonoBehaviour
{
    [SerializeField]
    private float Forca = 10;
    private Rigidbody2D fisica;
    private Diretor diretor;
    private Vector3 posicaoInicial;
    private bool deveImpulsionar;

    private void Awake()
    {
        fisica = GetComponent<Rigidbody2D>();
        diretor = GameObject.FindObjectOfType<Diretor>();
        posicaoInicial = this.transform.position;
    }
    private void Update()
    {
        if(Input.GetButtonDown(Tags.BotaoEsquerdoDoMouse))
        {
            deveImpulsionar = true;
        }
    }
    private void FixedUpdate()
    {
        if(deveImpulsionar)
            Impulsionar();
    }

    private void Impulsionar()
    {
        fisica.velocity = Vector2.zero;
        fisica.AddForce(Vector2.up * Forca, ForceMode2D.Impulse);
        deveImpulsionar = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        fisica.simulated = false;
        diretor.FinalizarJogo();
    }
    public void Reiniciar()
    {
        fisica.simulated = true;
        transform.position = posicaoInicial;
    }
}
