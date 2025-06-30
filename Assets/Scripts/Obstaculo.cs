using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private VariavelCompartilhadaFloat velocidade;
    [SerializeField]
    private float variacaoDaPosicaoY = 1.3f;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Update()
    {
        transform.Translate(Vector3.left * velocidade.valor * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
      if(outro.CompareTag("parede"))
      {
        Destruir();  
      }
    }

    public void Destruir()
    {
      GameObject.Destroy(gameObject);
    }
}
/*
private bool pontuei;
private Pontuacao pontuacao;
private Vector3 posicaoDoAviao;

private void Start()
{
    posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
    pontuacao = GameObject.FindObjectOfType<Pontuacao>();
}

if(!pontuei && transform.position.x < posicaoDoAviao.x)
{
  pontuei = true;
  pontuacao.AdicionarPontos();
}
*/
