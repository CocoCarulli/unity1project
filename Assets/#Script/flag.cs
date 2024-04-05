using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flag : MonoBehaviour
{
    [SerializeField] private flag nextOne;
    // Start is called before the first frame update
    void Start()
    {
        if(nextOne != null)
        {
            nextOne.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          if (nextOne != null)
        {
           nextOne.gameObject.SetActive(true);
        }
        }
        Debug.Log($"enter in to {name}");
        this.gameObject.SetActive(false);
    }
}
