using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CODIGODEOPCIONES : MonoBehaviour
{
  
   [SerializeField] private GameObject Respuesta;


   public void Pregunta()
   {
    Respuesta.SetActive(true);
   }
}
