using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raccogliere : MonoBehaviour
{
    static public bool check;
    // Start is called before the first frame update
    void Start()
    {
        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            check = true;
        }
    }
}
