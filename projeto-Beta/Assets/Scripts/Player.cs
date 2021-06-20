using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int pontos = 0;
    [SerializeField]
    private TextMeshProUGUI tela;
    
    private StreamWriter placar; 

    public float velocidade;
    public float forcaPulo;

    private Rigidbody2D rig;
    private int pulo;




    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        tela = GameObject.Find("Num").GetComponent<TextMeshProUGUI>();
        placar = new StreamWriter("Pontos.txt");
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(velocidade, rig.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {

            if (pulo < 2)
            {
                rig.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
                pulo += 1;
            }
        }

        tela.text = pontos.ToString();
       

        velocidade += (0.2f * Time.deltaTime);

        if (transform.position.y < -4)
        {
            placar.WriteLine(pontos.ToString());
            placar.Close();

            SceneManager.LoadScene("Fim");
        }
    }


     void OnCollisionEnter2D(Collision2D collider){
        if (collider.gameObject.layer == 8)
        {
            pulo = 0;
            pontos += 1;
        }
        else{
            if (collider.gameObject.layer == 9)
            {
            pulo = 0;
           
            }
        }


    }
     
}
