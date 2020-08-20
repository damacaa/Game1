using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    public GameObject player;
    public GameObject ball;

    LineRenderer rope;

    // Start is called before the first frame update
    void Start()
    {
        rope = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rope.SetPosition(0,player.transform.position);
        rope.SetPosition(1,ball.transform.position);
    }
}
