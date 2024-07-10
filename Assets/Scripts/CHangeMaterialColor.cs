using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHangeMaterialColor : MonoBehaviour
{
    [SerializeField] public Material mymaterial;

    // Start is called before the first frame update
    void Start()
    {
        mymaterial.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            mymaterial.color = Color.magenta;
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            mymaterial.color = Color.green;
        }
    }
}
