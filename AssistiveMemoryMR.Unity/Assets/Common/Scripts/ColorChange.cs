using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material matGreen;
    public Material matRed;

    // Start is called before the first frame update
    void Start()
    {
        this.SetMaterialRed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMaterialGreen()
    {
        this.gameObject.GetComponent<MeshRenderer>().material = this.matGreen;
    }
    public void SetMaterialRed()
    {
        this.gameObject.GetComponent<MeshRenderer>().material = this.matRed;
    }
}
