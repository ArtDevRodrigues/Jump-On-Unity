using UnityEngine;
using System.IO;
using TMPro;

public class MostarPontuacaoFinal : MonoBehaviour
{
    
    

    // Start is called before the first frame update
    void Start()
    {
        StreamReader placar = new StreamReader("Pontos.txt");
        GameObject.Find("Recorde").GetComponent<TextMeshProUGUI>().text = (placar.ReadLine()).ToString();
        placar.Close();

    }

    
}
