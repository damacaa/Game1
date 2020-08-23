using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public BallController ball;
    public float friction;
    public GameObject explosionPrefab;
    public LayerMask layerMask;
    public float ropeLength;

    Vector2 speedAcuumulated = Vector2.zero;

    float timeToPlay;
    public float waitToPlay;

    float maxChargeTime;
    bool charging;
    float charge;

    float nextTime;
    public float wait = 1.5f;

    // Start is called before the first frame update
    void Awake()
    {
        timeToPlay = Time.time + waitToPlay;
        charge = 0;
        ball.GetComponent<BallController>().r = ropeLength;
    }

    // Update is called once per frame
    public void Move(Vector2 speedInput)
    {
        speedInput *= speed * Time.deltaTime;

        transform.Translate(speedInput);
    }

    private void Update()
    {
        Vector2 ropeVector = ball.transform.position - transform.position;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, ropeVector.normalized, ball.r, layerMask.value);

        Collider2D ownCollider = gameObject.GetComponent<Collider2D>();

        if (hit && Time.time > timeToPlay)//&& hit.collider != ownCollider
        {
            Die();
            //Debug.Log(hit.collider.gameObject.name);
        }

        if (charging)
        {
            if (Time.time > maxChargeTime)
            {
                Boost();
            }
            else
            {
                charge += Time.deltaTime;
            }
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ball" && collision.gameObject.GetComponent<BallController>().parent.transform == gameObject.transform && Time.time > timeToPlay)
        {
            Debug.Log("Colision");

            Vector2 distance = gameObject.transform.position - collision.transform.position;

            gameObject.GetComponent<Rigidbody2D>().AddForce(distance.normalized * 5000 * charge);

            charge = 0;
        }
    }

    public void Die()
    {
        /*while (gameObject.transform.childCount != 0)
        {
            Destroy(gameObject.transform.GetChild(0).gameObject);
        }*/
        Destroy(ball.gameObject);
        Destroy(gameObject);
        Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
    }

    public void Charge()
    {
        if (!charging)
        {
            charging = ball.Charge();
            
            maxChargeTime = Time.time + 1f;
        }
    }

    public void Boost()
    {
        if (charging && Time.time > nextTime)
        {
            Debug.Log(charge);
            charging = false;
            gameObject.GetComponent<AudioSource>().Play();
            ball.Boost();
            nextTime = Time.time + wait;
        }
    }

    public void SetRopeLength(float r)
    {
        ropeLength = r;
        ball.GetComponent<BallController>().r = r;
    }

    public void ResetBall()
    {
        ball.Reset();
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}
