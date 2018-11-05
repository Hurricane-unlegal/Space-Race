using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    float x = 1f;
    float y = 1f;
    float z = 1f;
    float x1 = 1f;
    float y1 = 1f;
    float z1 = 1f;
    void Start()
    {
        x = Random.Range(-1f, 1f);
        y = Random.Range(-1f, 1f);
        z = Random.Range(-1f, 1f);
        x1 = Random.Range(0.5f, 2f);
        y1 = Random.Range(0.5f, 2f);
        z1 = Random.Range(0.5f, 2f);
        this.transform.localScale += new Vector3(x1, y1, z1);
    }

    void Update () {
        this.transform.Rotate(x, y, z);
    }
}
