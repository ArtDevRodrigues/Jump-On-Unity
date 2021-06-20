using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorDePontos : MonoBehaviour
{
    private int pontos;
    [SerializeField]
    private TextMeshProUGUI tela;


    void Start()
    {

        tela = GetComponent<TextMeshProUGUI>();

    }

    
    void Update()
    {
        
        tela.text = pontos.ToString();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            pontos += 1;

        }

    }

}
