using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeracaoDeMapa : MonoBehaviour
{

    public GameObject Base;
    public float altura;

    GameObject newBase;
    private float posicao;
   
    



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        newBase = Instantiate(Base);
        newBase.transform.position = transform.position + new Vector3(posicao, Random.Range(-altura, altura), 0);
        posicao += 8;


    }



}
