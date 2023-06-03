using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemadeJuego : MonoBehaviour
{
    [SerializeField] private GameObject BotonRespuesta;
    [SerializeField] private GameObject MenuJuego;

    public void Correcto()
    {
        BotonRespuesta.SetActive(true);
        MenuJuego.SetActive(false);
    }
}
