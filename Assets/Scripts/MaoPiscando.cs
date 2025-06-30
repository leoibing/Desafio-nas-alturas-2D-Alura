using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaoPiscando : MonoBehaviour
{
	private SpriteRenderer imagem;
	//private TeclaPressionada teclaPressionada;

	private void Awake()
	{
		imagem = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		if (Input.GetButtonDown("Fire1") ^ Input.GetButtonDown("Jump") /*^ Input.GetKeyDown(teclaPressionada.tecla)*/)
		{
			Desaparecer();
		}
	}

	public void Desaparecer()
	{
		imagem.enabled = false;
	}
}
