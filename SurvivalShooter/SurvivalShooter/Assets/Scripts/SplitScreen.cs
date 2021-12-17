using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitScreen : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    // Start is called before the first frame update
    void Start()
    {
        cam1.rect = new Rect(0, 0, 1, 0.5f);
        cam2.rect = new Rect(0, 0.5f, 1, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
