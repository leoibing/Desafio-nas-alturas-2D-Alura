using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoComputador : MonoBehaviour
{
    [SerializeField]
    private float intervalo;
    private Aviao aviao;
    
    private void Start()
    {
        aviao = GetComponent<Aviao>();
        StartCoroutine(Impulsionar());
    }

    private IEnumerator Impulsionar()
    {
      while(true)
      {
        yield return new WaitForSecondsRealtime(intervalo);
        aviao.DarImpulso();
      }
    }
}
