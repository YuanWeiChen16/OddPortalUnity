using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public float destination;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            Debug.Log("PPPPPPPPPPPPPPPPPPP");
            Vector3 tempv = other.transform.GetComponent<Transform>().position;
            tempv.z += destination;
            other.transform.GetComponent<Transform>().position = tempv;
        }
    }
}
