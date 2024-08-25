using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehavior : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.transform.position = new Vector3(-0.93f, 0, -10);
    }

    // Update is called once per frame
    void Update()
    {
        if((player.transform.position.x > -0.93) && (player.transform.position.x < 32.8))
        {
            cam.transform.position = new Vector3(player.transform.position.x, 0, -10);
        }
    }
}
