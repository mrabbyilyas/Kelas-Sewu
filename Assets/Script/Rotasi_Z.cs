using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotasi_Z : MonoBehaviour
{
    public float Kecepatan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Kecepatan * 10 * Time.deltaTime);
    }
}
