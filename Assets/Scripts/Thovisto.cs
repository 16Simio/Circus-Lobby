using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thovisto : MonoBehaviour
{
    public GameObject checkpoint;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        print("ontrigger");
        if (other.gameObject.CompareTag("Player"))
        {
            print("player");
            if (PlayerMovement.visibile)
            {
                player.transform.position = checkpoint.transform.position;
                print("check");
            }
        }
    }
}
