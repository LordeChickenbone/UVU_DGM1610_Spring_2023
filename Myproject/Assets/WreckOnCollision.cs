using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckOnCollision : MonoBehaviour
{
    public GameObject wreckedVersion;

    private void OnCollisionEnter()
    {
        Destroy(gameObject);
        Instantiate(wreckedVersion, transform.position, transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
