using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    private Aviao aviao;
    private Pontuacao pontuacao;
    private InterfaceGameOver interfaceGameOver;

    protected virtual void Start()
    {
      aviao = GameObject.FindObjectOfType<Aviao>();
      pontuacao = GameObject.FindObjectOfType<Pontuacao>();
      interfaceGameOver = GameObject.FindObjectOfType<InterfaceGameOver>();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;//congela o tempo
        pontuacao.SalvarRecorde();
        interfaceGameOver.MostrarInterface();
    }

    public virtual void ReiniciarJogo()
    {
        interfaceGameOver.EsconderInterface();
        Time.timeScale = 1;
        aviao.Reiniciar();
        DestruirObstaculos();
        pontuacao.Reiniciar();
    }

    private void DestruirObstaculos()
    {
      Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
      foreach (Obstaculo obstaculo in obstaculos)
      {
        obstaculo.Destruir();
      }
    }
}
