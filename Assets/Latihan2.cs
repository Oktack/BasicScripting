using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan2 : MonoBehaviour
{
    public int nilaiA = 5;
    public int nilaiB = 9;
    [Range(1, 5)]
    public int nilaiC;
    void Start()
    {
        int totall = (nilaiA + nilaiB) * nilaiC;
        Debug.Log("Total " + totall);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
