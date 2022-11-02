using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text Tiempo;
    public int timer2;
    private float restante;
    private bool enMarcha;
    private void Awake()
    {
        restante = (min * 60) + seg;
        timer2 = (min * 60) + seg;
        enMarcha = true;

    }
    private void Update()
    {
        if (enMarcha)
        {
            
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                SceneManager.LoadScene("Game_Over");
                    }
            int temMin = Mathf.FloorToInt(restante / 60);
            int temSeg = Mathf.FloorToInt(restante % 60);
            Tiempo.text = string.Format("{00:00}:{01:00}", temMin, temSeg);
            timer2 = (int)(30-restante) + 1;
            WinTimer.tomer = timer2;
        }
    }
}
