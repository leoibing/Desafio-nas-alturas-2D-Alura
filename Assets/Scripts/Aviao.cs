using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Photon.Pun;
using Photon.Realtime;

public class Aviao : MonoBehaviour
{
  private Rigidbody2D fisica;
  [SerializeField]//"publico" para Unity
  private float forca = 10;
  [SerializeField]
  private UnityEvent aoBater;
  [SerializeField]
  private UnityEvent aoPassarPeloObstaculo;
  private Vector3 posicaoInicial;
  private bool deveImpulsionar;
  private Animator animacao;

    private void Awake()//é chamado assim que o objeto é criado
    {
      posicaoInicial = transform.position;
      fisica = GetComponent<Rigidbody2D>();
      animacao = GetComponent<Animator>();
    }

//Enquanto o método GetComponent busca as dependências dentro do próprio objeto onde está nosso componente. O método FindObjectOfType busca a dependência dentro da cena inteira.
    private void Update()
    {
		/*if(photonView.IsMine)
		{*/
			animacao.SetFloat("VelocidadeY", fisica.velocity.y);
		/*}*/
    }

    private void FixedUpdate()//obrigatório para fisica
    {
		/*if(photonView.IsMine)
		{*/
			if(deveImpulsionar)
			{
			  Impulsionar();
			}
		/*}*/
    }

    public void DarImpulso()
    {
      deveImpulsionar = true;
    }

    public void Reiniciar()
    {
		/*if(photonView.IsMine)
		{*/
			transform.position = posicaoInicial;
			fisica.simulated = true;
		/*}*/
    }

    private void Impulsionar()
    {
      fisica.velocity = Vector2.zero;
      fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
      deveImpulsionar = false;
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
      fisica.simulated = false;
      aoBater.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      aoPassarPeloObstaculo.Invoke();
    }
}
/*
if(Input.GetButtonDown("Fire1") ^ Input.GetButtonDown("Jump"))
{
  deveImpulsionar = true;
}

private Diretor diretor;

private void Start() é chamado apenas quando a cena inteira já foi criada
{
  diretor = GameObject.FindObjectOfType<Diretor>();
}

diretor.FinalizarJogo();
*/
