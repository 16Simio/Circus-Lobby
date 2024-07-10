using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancioCOsa : MonoBehaviour
{
    public GameObject ciao;
    public GameObject ciaone;
    public GameObject cono;
    public bool controll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.E) && controll == true)
        {
            ciao.SetActive(true);
            ciaone.SetActive(false);
            cono.SetActive(true);
        }*/
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E) && Raccogliere.check == true)
            {
                ciao.SetActive(true);
                ciaone.SetActive(false);
                cono.SetActive(true);
                Raccogliere.check = false;
            }
        }
    }


}
