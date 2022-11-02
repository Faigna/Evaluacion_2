using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntajes : MonoBehaviour
{
    public static float score;
    public Text scoreText;
    public Text Cantidad;
       void Start()
    {
    }
    private void Update()
    {
    
        scoreText.text= "ObjetivosDestruidos:" + score;
    }

}
