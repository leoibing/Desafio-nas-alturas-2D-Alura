using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private void Awake()
	{
		int quantidade = FindObjectsOfType<GameManager>().Length;
		if (quantidade > 1)
		{
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);
	}

	public void IniciaJogo()
	{
		StartCoroutine(Cena01());
	}

	IEnumerator Cena01()
	{
		yield return new WaitForSeconds(0.5f);

		SceneManager.LoadScene(1);
	}

	public void Inicio()
	{
		StartCoroutine(Cena00());
	}

	IEnumerator Cena00()
	{
		yield return new WaitForSeconds(2f);

		SceneManager.LoadScene(0);
	}

}
