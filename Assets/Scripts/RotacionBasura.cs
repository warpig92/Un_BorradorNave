using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionBasura : MonoBehaviour
{

    [SerializeField]
    private float velocidadRotacion = 0;
    [SerializeField]
    private Transform Planeta;
    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(Planeta.transform.position,Vector3.forward,Time.deltaTime * velocidadRotacion);
    }
}
