using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    private Vector3 offset;

    void Start()
    {
        offset = Player.position - transform.position;
    }
    
    void Update()
    {
        transform.position = Player.position - offset;
    }
}
