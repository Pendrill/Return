using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableMaterial : MonoBehaviour
{

    private bool _disabledMaterial = false;
    public Image image;
    public Material scrabledMat;
    public Material defaultMat;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            if(!_disabledMaterial)
            {
                DisableShader();
                _disabledMaterial = true;
            }
        }
        else if(_disabledMaterial)
        {
            EnableShader();
            _disabledMaterial = false;
        }
    }

    void DisableShader()
    {
        image.material = defaultMat;
    }

    void EnableShader()
    {
        image.material = scrabledMat;
    }
}
