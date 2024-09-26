using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printPosicion : MonoBehaviour
{
    private GameObject[] objetos;
    // Start is called before the first frame update
    void Start()
    {
        objetos = GameObject.FindGameObjectsWithTag("objetos");
        foreach (GameObject obj in objetos) {
            Transform t = obj.GetComponent<Transform>();
            Debug.Log(obj.name + ": " + t.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
