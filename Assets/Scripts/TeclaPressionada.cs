using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TeclaPressionada : MonoBehaviour
{
	[SerializeField]
	public KeyCode tecla;
	[SerializeField]
	private UnityEvent aoPressionarTecla;
	//private MaoPiscando maoPiscando;

	private void Update()
	{
		if (Input.GetKeyDown(tecla))
		{
			aoPressionarTecla.Invoke();
			//maoPiscando.Desaparecer();
		}
	}
}
/*
private Aviao aviao;

private void Start()
{
    aviao = GetComponent<Aviao>();
}

aviao.DarImpulso();
*/
