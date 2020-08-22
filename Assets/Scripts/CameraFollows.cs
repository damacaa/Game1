using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{

    Camera cam;

    public GameObject[] players;
    public int numberOfPlayers = 1;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        players = new GameObject[numberOfPlayers];
        cam = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(0f, 0f, 0f);

        bool allInViewport = true;

        for (int i = 0; i < players.Length; i++)
        {
            if (players[i] != null)
            {
                newPos += players[i].transform.position;
                Vector2 viewPos = cam.WorldToViewportPoint(players[i].transform.position);

                if (viewPos.x > 0.8F || viewPos.x < 0.2F || viewPos.y > 0.7F || viewPos.y < 0.3F)
                {
                    cam.orthographicSize += speed*Time.deltaTime;
                    
                }else if (viewPos.x > 0.79F || viewPos.x < 0.21F || viewPos.y > 0.69F || viewPos.y < 0.31F) { allInViewport = false; }
            }
        }

        if (allInViewport && cam.orthographicSize > 20) { cam.orthographicSize -= speed * Time.deltaTime; }



        newPos /= numberOfPlayers;

        newPos.y += 3;
        newPos.z = -10;

        //transform.position = newPos;
        transform.Translate((newPos - transform.position) * Time.deltaTime * 5);
    }
}
