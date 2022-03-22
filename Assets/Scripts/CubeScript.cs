using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float KillDistance;

    private Rigidbody rigidbodyRef;
    private Vector3 spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyRef = GetComponent<Rigidbody>();
        spawnpoint = rigidbodyRef.position;
    }

    // Update is called once per frame
    void Update()
    {
        if ((rigidbodyRef.position - spawnpoint).magnitude >= KillDistance)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
