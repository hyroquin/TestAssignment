using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject SpawnObject;
    public Vector3 SpawnPoint;
    public Vector3 Direction;
    public float SpawnPeriod;
    public float KillDistance;
    public float Speed;

    private float timer;
    private CubeScript csRef;
    private GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        csRef = SpawnObject.GetComponent<CubeScript>();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= SpawnPeriod)
        {
            Spawn();
            timer = 0;
        }
    }

    void Spawn()
    {
        csRef.KillDistance = KillDistance;
        cube = Instantiate(SpawnObject, SpawnPoint, Quaternion.identity);
        cube.GetComponent<Rigidbody>().velocity = Direction.normalized * Speed;
    }

    public void UpdateSpeed(string newspeed)
    {
        Speed = float.Parse(newspeed);
    }

    public void UpdateDistance(string newdistance)
    {
        KillDistance = float.Parse(newdistance);
    }

    public void UpdatePeriod(string newperiod)
    {
        SpawnPeriod = float.Parse(newperiod);
    }
}
