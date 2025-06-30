using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiretorMultiplayer : Diretor
{
    [SerializeField]
    private int pontosParaReviver;
    private Jogador[] jogadores;
    private bool alguemMorto;
    private int pontosDesdeAMorte;
    private InterfaceCanvasInativo interfaceInativo;

    protected override void Start()
    {
      base.Start();
      jogadores = GameObject.FindObjectsOfType<Jogador>();
      interfaceInativo = GameObject.FindObjectOfType<InterfaceCanvasInativo>();
    }

    public void AvisarQueAlguemMorreu(Camera camera)
    {
      if(alguemMorto)
      {
        interfaceInativo.Sumir();
        FinalizarJogo();
      }
      else
      {
        alguemMorto = true;
        pontosDesdeAMorte = 0;
        interfaceInativo.AtualizarTexto(pontosParaReviver);
        interfaceInativo.Mostrar(camera);
      }
    }

    public override void ReiniciarJogo()
    {
      base.ReiniciarJogo();
      ReviverJogadores();
    }

    public void ReviverSePrecisar()
    {
      if(alguemMorto)
      {
        pontosDesdeAMorte++;
        interfaceInativo.AtualizarTexto(pontosParaReviver - pontosDesdeAMorte);
        if(pontosDesdeAMorte >= pontosParaReviver)
        {
          interfaceInativo.Sumir();
          ReviverJogadores();
        }
      }
    }

    private void ReviverJogadores()
    {
      alguemMorto = false;
      foreach(var jogador in jogadores)
      {
        jogador.Ativar();
      }
    }
}
