using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MenuPausa : MonoBehaviour
{

   [SerializeField] private GameObject MenuPausaa;


   public void Pausa()
   {
   
    MenuPausaa.SetActive(true);
 
   }
 }