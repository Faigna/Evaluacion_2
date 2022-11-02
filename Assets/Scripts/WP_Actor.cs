using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WP_Actor : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform target;
    public int vida;
    public int puntos;
    void Start()
    {
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        if (vida <= 0)
        {
            Destroy(gameObject);
            puntos = 1;
            Puntajes.score += puntos;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WayPoint")
        {
            target = other.gameObject.GetComponent<WayPoint>().nextPoint;
            transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        }
        if (other.tag == "Bala")
        {
            vida--;

        }
    }


}
