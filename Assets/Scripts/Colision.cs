using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Colision : MonoBehaviour
{
        public int salud;
    public Puntaje_Manager pm;
    public Text Vidas;
    public AudioClip Damage;
    AudioSource Audio;
    // Update is called once per frame
    void Start()
    {
    }
    void Awake()
    {
        pm = FindObjectOfType<Puntaje_Manager>();
        Audio = GetComponent<AudioSource>();

    }
  
    void Update()
   { 
            if (salud <= 0)
            {
               SceneManager.LoadScene("MainMenu" ,LoadSceneMode.Single);
        }
        Vidas.text = "Vidas:" + salud;
    }

        void OnTriggerEnter(Collider other)
        {
           
            if (other.tag == "Enemigo")
            {
                salud--;
            pm.puntaje++;
            Audio.PlayOneShot(Damage);

        }
            if (other.tag == "Meta")
        {
            SceneManager.LoadScene("Win");

        }
    }


    }


