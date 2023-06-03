using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sistemaaa : MonoBehaviour
{
    [SerializeField] private GameObject Boton;
    [SerializeField] private GameObject Panel;
    [SerializeField] private GameObject Boton1;
     [SerializeField] private GameObject boton2;
    [SerializeField] private GameObject boton;
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject MenuPausa;
    

    
    [SerializeField] public float tiempoEspera = 2f;
    [SerializeField] public GameObject panel;
    [SerializeField] public GameObject Coso;
    [SerializeField] public GameObject panel1;
    [SerializeField] public CanvasGroup canvasGroup;
    [SerializeField] public CanvasGroup canvasGroup2;

    [SerializeField] public AudioSource ControladorSonido;
    [SerializeField] public AudioClip SondioDeVictoria;
    [SerializeField] public AudioClip SondioDeDerrota;
    [SerializeField] public AudioClip Español;
    [SerializeField] public AudioClip Ingles;

    [SerializeField] public string[] escenas;


    public void Aparecer(){
        Panel.SetActive(true);
        Coso.SetActive(false);
        SiguienteNivel();

    }

    public void SiguienteNivel(){
        Boton1.SetActive(false);
        boton.SetActive(false);
        boton2.SetActive(false);
        
       
        Correcto();
    }

    public void Correcto(){
        canvasGroup2.interactable = false;
        canvasGroup2.blocksRaycasts = false;
        panel1.SetActive(false);

        Invoke("ActivarPanel2", tiempoEspera);
    }

    public void ActivarPanel2() {
        Menu.SetActive(false);
        canvasGroup2.interactable = true;
        canvasGroup2.blocksRaycasts = true;
        panel1.SetActive(true);
        ControladorSonido.PlayOneShot(SondioDeVictoria);
        

        }


     public void Jugar()
    {
        Reintentar();
    }

    public void Incorrecto()
     {
        Color nuevoColor = Color.green;
        boton.GetComponent<Image>().color = nuevoColor;
        Color nuevoColor2 = Color.red;
        Boton1.GetComponent<Image>().color = nuevoColor2;
        Color nuevoColor3 = Color.red;
        boton2.GetComponent<Image>().color = nuevoColor3;

        menudeerror();
     }

    public void menudeerror()
    {
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        panel.SetActive(false);

        Invoke("ActivarPanel", tiempoEspera);
    }

    public void ActivarPanel() {
        Menu.SetActive(false);
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        panel.SetActive(true);
        ControladorSonido.PlayOneShot(SondioDeDerrota);

    }

    public void Reintentar()
    {
       int indice = Random.Range(0, escenas.Length);
       SceneManager.LoadScene(escenas[indice]);
    }

    public void VozEnEspañol()
    {
        ControladorSonido.PlayOneShot(Español);
    }

    public void VozEnIngles()
    {
        ControladorSonido.PlayOneShot(Ingles);
    }

    public void saliralinicio()
    {
        SceneManager.LoadScene(0);
    }

    public void Pausa()
    {
        MenuPausa.SetActive(true);
        Menu.SetActive(false);
    }

    public void SalirPausa()
    {
        MenuPausa.SetActive(false);
        Menu.SetActive(true);
    }
}

 


