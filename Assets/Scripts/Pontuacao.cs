using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text textoPontuacao;
    [SerializeField]
    private UnityEvent aoPontuar;
    public int Pontos{get; private set;}
    private AudioSource audioPontuacao;

    private void Awake()
    {
        audioPontuacao = GetComponent<AudioSource>();
    }

    public void AdicionarPontos()
    {
        Pontos++;
        textoPontuacao.text = Pontos.ToString();
        audioPontuacao.Play();
        aoPontuar.Invoke();
    }

    public void Reiniciar()
    {
        Pontos = 0;
        textoPontuacao.text = Pontos.ToString();
    }

    public void SalvarRecorde()
    {
        int recordeAtual = PlayerPrefs.GetInt("recorde");
        if (Pontos > recordeAtual)
        {
            PlayerPrefs.SetInt("recorde", Pontos);
        }
    }
}
