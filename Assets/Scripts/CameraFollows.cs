using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{

    Camera cam;

    public GameObject[] players;
    public int numberOfPlayers = 1;

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

                if (viewPos.x > 0.9F || viewPos.x < 0.1F || viewPos.y > 0.9F || viewPos.y < 0.1F)
                {
                    cam.orthographicSize += 0.2f;
                    
                }else if (viewPos.x > 0.89F || viewPos.x < 0.11F || viewPos.y > 0.89F || viewPos.y < 0.11F) { allInViewport = false; }
            }
        }

        if (allInViewport && cam.orthographicSize > 20) { cam.orthographicSize -= 0.1f; }



        newPos /= numberOfPlayers;

        newPos.y += 3;
        newPos.z = -10;

        //transform.position = newPos;
        transform.Translate((newPos - transform.position) * Time.deltaTime * 5);
    }
}
