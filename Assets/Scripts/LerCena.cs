using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LerCena : MonoBehaviour
{

	public void CarregarCena(string cena)
	{
		StartCoroutine(IECena(cena));
		Time.timeScale = 1;
	}

	IEnumerator IECena(string cena)
	{
		yield return new WaitForSeconds(0.5f);

		SceneManager.LoadScene(cena);
	}
}
