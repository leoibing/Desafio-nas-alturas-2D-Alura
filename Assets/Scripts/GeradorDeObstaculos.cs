using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
  [SerializeField]
  private float tempoParaGerarFacil;
  [SerializeField]
  private float tempoParaGerarDificil;

  [SerializeField]
  private GameObject manualDeInstrucoes;//Obstaculo
  private float cronometro;
  private ControleDeDificuldade controleDeDificuldade;
  private bool parado;

    private void Awake()
    {
      cronometro = tempoParaGerarFacil;
    }

    private void Start()
    {
      controleDeDificuldade = GameObject.FindObjectOfType<ControleDeDificuldade>();
    }

    private void Update()
    {
      if(parado)
      {
        return;
      }
      cronometro -= Time.deltaTime;
      if(cronometro < 0)
      {
        GameObject.Instantiate(manualDeInstrucoes, transform.position, Quaternion.identity);//sem rotacao
        cronometro = Mathf.Lerp
          (tempoParaGerarFacil, tempoParaGerarDificil, controleDeDificuldade.Dificuldade);
      }
    }

    public void Parar()
    {
      parado = true;
    }

    public void Recomecar()
    {
      parado = false;
    }
}
