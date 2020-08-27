using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float r;
    public float defaultR;
    public float w;
    public Transform parent;

    float phi;
    public bool accelerating;
    public bool canBoost;
    public bool waiting;
    public bool charging;


    float nextTime;
    public float wait = 1.5f;


    Vector2 globalPosition;

    // Start is called before the first frame update
    void Awake()
    {
        nextTime = Time.time;
        //transform.SetParent(parent);
        phi = UnityEngine.Random.Range(0f, 2 * Mathf.PI);
        canBoost = true;

        Vector3 newPos = new Vector3(r * Mathf.Cos(phi), r * Mathf.Sin(phi), 0);
        transform.localPosition += 0.1f * (newPos - transform.localPosition);
        phi += w * Time.deltaTime;

        //Debug.Log("Awake: " + r);
    }

    private void Start()
    {
        //r = 10;
        r = defaultR;
        
        //Debug.Log("Start: " + r);

    }

    // Update is called once per frame
    void Update()
    {

        if (phi >= 2 * Mathf.PI)
        {
            phi = 0;
        }

        if (charging) {
            Debug.Log("Cargando");
        }
        else if (accelerating)
        {
            r = 0;
            gameObject.transform.Translate((parent.position - transform.position) * 0.1f);

        }
        else if (waiting)
        {
            if (Time.time > nextTime)
            {
                Reset();
            }
            else
            {
                r = (parent.position - transform.position).magnitude;
            }
        }
        else
        {
            Vector3 newPos = new Vector3(r * Mathf.Cos(phi), r * Mathf.Sin(phi), 0);
            transform.localPosition += 0.1f * (newPos - transform.localPosition);
            phi += w * Time.deltaTime;
        }
    }

    public bool Charge()
    {
        if (canBoost)
        {
            charging = true;
        }

        return canBoost;
    }
    public void Boost()
    {
        charging = false;
        accelerating = true;
        canBoost = false;
        waiting = false;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")// && collision.transform.parent.ToString() == parent.ToString()
        {
            waiting = true;
            accelerating = false;
            nextTime = Time.time + wait;
            gameObject.transform.parent = null;
        }
    }

    public void Reset()
    {
        gameObject.transform.parent = parent;
        canBoost = true;
        waiting = false;
        accelerating = false;
        charging = false;
        r = defaultR;
        nextTime = 0;
    }
}
