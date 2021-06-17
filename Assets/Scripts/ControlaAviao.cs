using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaAviao : MonoBehaviour
{
    public float Forca = 10;
    private Rigidbody2D fisica;

    private void Awake()
    {
        fisica = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetButtonDown(Tags.BotaoEsquerdoDoMouse))
        {
            Impulsionar();
        }
    }

    private void Impulsionar()
    {
        fisica.AddForce(Vector2.up * Forca, ForceMode2D.Impulse);
    }
}
