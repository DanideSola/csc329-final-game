using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Code borrowed from: https://www.youtube.com/watch?v=9KOHclqSmR4 

    [SerializeField] private GameObject grimReaper;
    public Timer t;
    bool hasSpawned = false;

    private void Update()
    {
        if (t.time == 0) {
            Spawn();
            hasSpawned = true;
        }
    }

    private void Spawn() {
        if (hasSpawned == false) {
            Instantiate(grimReaper, transform.position, transform.rotation);
        }
    }
}
