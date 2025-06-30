using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sair : MonoBehaviour
{
	public GameObject BotaoSair;

#if UNITY_ANDROID
	private void Awake()
	{
		Input.backButtonLeavesApp = true; // Botão voltar pode sair do jogo
		//System.Diagnostics.Process.GetCurrentProcess().Kill();
	}
#endif

#if (UNITY_WEBGL || UNITY_IOS) && !UNITY_EDITOR
	private void Start()
	{
		BotaoSair.SetActive(false);
	}

#else
	public void Exit()
	{
		StartCoroutine(IESair());
	}

	IEnumerator IESair()
	{
		yield return new WaitForSeconds(0.5f);

#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false; //UnityEditor.EditorApplication.ExitPlaymode();
#endif
		Application.Quit();
	}
#endif
}
