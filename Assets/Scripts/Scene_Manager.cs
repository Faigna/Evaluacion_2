using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public void escena_facil()
    {
        SceneManager.LoadScene("Facil", LoadSceneMode.Single);

    }
    public void escena_medio()
    {
        SceneManager.LoadScene("Normal", LoadSceneMode.Single);

    }
    public void escena_dificil()
    {
        SceneManager.LoadScene("Dificil", LoadSceneMode.Single);

    }
}
