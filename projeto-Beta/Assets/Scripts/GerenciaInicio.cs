using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciaInicio : MonoBehaviour
{
    public void MudaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    } 
    
}
