using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{
    [SerializeField]
    private VariavelCompartilhadaFloat velocidade;

    private Vector3 posicaoInicial;
    private float tamanhoRealDaImagem;

    private void Awake()
    {
      posicaoInicial = transform.position;
      float tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
      float escala = transform.localScale.x;
      tamanhoRealDaImagem = tamanhoDaImagem * escala;
    }

    void Update()
    {
        float deslocamento = Mathf.Repeat(velocidade.valor * Time.time, tamanhoRealDaImagem/2);//O Time.time retorna o tempo que se passou desde o inicio do jogo até o momento atual.
        transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
