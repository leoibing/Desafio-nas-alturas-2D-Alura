using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    private Carrossel[] cenario;
    private GeradorDeObstaculos obstaculo;
    private Aviao aviao;
    private bool estouMorto;

    private  void Start()
    {
      cenario = GetComponentsInChildren<Carrossel>();
      obstaculo = GetComponentInChildren<GeradorDeObstaculos>();
      aviao = GetComponentInChildren<Aviao>();
    }

    public void Desativar()
    {
        estouMorto = true;
        obstaculo.Parar();
        foreach(var carrossel in cenario)
        {
          carrossel.enabled = false;
        }
    }

    public void Ativar()
    {
      if(estouMorto)
      {
        aviao.Reiniciar();
        obstaculo.Recomecar();
        foreach(var carrossel in cenario)
        {
          carrossel.enabled = true;
        }
        estouMorto = false;
      }
    }

}
