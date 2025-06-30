using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicaInstancia : MonoBehaviour
{
	[SerializeField]
	private bool sobrescreverExistente;

    private void Start()
    {
        var outros = GameObject.FindGameObjectsWithTag(tag);
				for(var i = 0; i < outros.Length; i++)
				{
					var outro = outros[i];

					if(outro != gameObject)
					{
						if(sobrescreverExistente)
						{
							GameObject.Destroy(outro);
						}
						else
						{
							GameObject.Destroy(gameObject);
						}
					}
				}
    }
}
/*
var outrasInstancias = GameObject.FindGameObjectsWithTag(tag);
		foreach(var instancia in outrasInstancias)
		{
			if(instancia != gameObject)
			{
				GameObject.Destroy(instancia.gameObject);
			}
		}
}
*/
