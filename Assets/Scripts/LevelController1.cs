using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class LevelController1 : LevelController
{
    public Camera cam;
    CameraFollows camF;

    public LineRenderer line;


    public GameObject screenControls;
    public GameObject endUI;
    public GameObject gameplayUI;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI ropeLengthText;
    public TextMeshProUGUI targetPointsText;
    public TextMeshProUGUI winText;

    public GameObject playerPrefab;

    public LayerMask playerLayer;
    public LayerMask enemyLayer;



    

    public int range;
    int lastRange;
    public int ropeLength;
    public int targetPoints;


    PlayerController p1;
    PlayerController p2;

    PlayerControls controls;
    Vector2 move1;
    Vector2 move2;

    int points1 = -1;
    int points2 = -1;

    bool started;


    // Start is called before the first frame update
    void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        AllowScreenRotation(false);
        SetAndroidPerformance();

        camF = cam.GetComponent<CameraFollows>();
        camF.numberOfPlayers = 2;

        controls = new PlayerControls();

        controls.Player1.Boost1.started += ctx => p1.Charge();
        controls.Player1.Boost1.canceled += ctx => p1.Boost();


        controls.Player1.MoveJoystick1.performed += ctx => move1 = ctx.ReadValue<Vector2>();
        controls.Player1.MoveJoystick1.canceled += ctx => move1 = Vector2.zero;

        controls.Player1.MoveKeyboard1.performed += ctx => move1 = ctx.ReadValue<Vector2>();
        controls.Player1.MoveKeyboard1.canceled += ctx => move1 = Vector2.zero;

        controls.Player2.Boost1.started += ctx => p2.Charge();
        controls.Player2.Boost1.canceled += ctx => p2.Boost();

        controls.Player2.MoveJoystick1.performed += ctx => move2 = ctx.ReadValue<Vector2>();
        controls.Player2.MoveJoystick1.canceled += ctx => move2 = Vector2.zero;

        controls.Player2.MoveKeyboard1.performed += ctx => move2 = ctx.ReadValue<Vector2>();
        controls.Player2.MoveKeyboard1.canceled += ctx => move2 = Vector2.zero;

        ropeLengthText.text = ropeLength.ToString();
        targetPointsText.text = targetPoints.ToString();
    }

    public void StartGame()
    {
        started = true;
        ropeLengthText.text = ropeLength.ToString();
        lastRange = range;

        line.enabled = true;
        DrawTheCircle();
    }

    private void DrawTheCircle()
    {
        int i = 0;
        Vector3 newPos;
        float localRange = range + (line.startWidth/4);
        for (float phi = 0; phi <= 2 * Mathf.PI; phi += 0.1f)
        {
            newPos = new Vector3(2 * localRange * Mathf.Cos(phi), 2 * localRange * Mathf.Sin(phi), 0);

            line.SetPosition(i, newPos);
            i++;
        }

        //line.SetPosition(i, new Vector3(2*range,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        if (started)
        {
            if (p1)
            {
                p1.Move(move1);

                bool inside = Vector3.Distance(p1.transform.position, Vector3.zero) < 2 * range;

                if (!inside) { p1.Die(); }
            }
            else
            {
                points2++;
                if (points2 >= targetPoints)
                {
                    End();
                }
                else {
                    GameObject newPlayer = GameObject.Instantiate(playerPrefab, new Vector3(UnityEngine.Random.Range(-range, range), UnityEngine.Random.Range(-range, range), 0), Quaternion.identity);
                    newPlayer.layer = 8;
                    newPlayer.name = "Dani";
                    p1 = newPlayer.GetComponent<PlayerController>();
                    p1.layerMask = enemyLayer;
                    p1.SetRopeLength(ropeLength);
                    camF.players[0] = newPlayer;
                }
                
                
            }

            if (p2)
            {
                p2.Move(move2);

                bool inside = Vector3.Distance(p2.transform.position, Vector3.zero) < 2 * range;

                if (!inside) { p2.Die(); }
            }
            else
            {
                
                points1++;
                

                if (points1 >= targetPoints)
                {
                    End();
                }
                else {
                    GameObject newPlayer = GameObject.Instantiate(playerPrefab, new Vector3(UnityEngine.Random.Range(-range, range), UnityEngine.Random.Range(-range, range), 0), Quaternion.identity);
                    newPlayer.layer = 9;
                    newPlayer.name = "Juanje";
                    p2 = newPlayer.GetComponent<PlayerController>();
                    p2.layerMask = playerLayer;
                    p2.SetRopeLength(ropeLength);
                    camF.players[1] = newPlayer;
                }
            }

            scoreText.text = points1 + ":" + points2;
        }

        if(lastRange != range)
        {
            DrawTheCircle();
            lastRange = range;
        }
    }

    private void OnEnable()
    {
        controls.Player1.Enable();
        controls.Player2.Enable();
    }

    private void OnDisable()
    {
        controls.Player1.Disable();
        controls.Player2.Disable();
    }

    public void HideHud()
    {
        screenControls.SetActive(!screenControls.activeSelf);
    }

    void End()
    {
        gameplayUI.SetActive(false);
        endUI.SetActive(true);
        started = false;
        gameObject.GetComponent<AudioSource>().loop = false;

        if(points2 > points1)
        {
            winText.gameObject.transform.Rotate(180*Vector3.forward);
        }
    }

    public void IncreaseRopeLength()
    {
        ropeLength += 1;
        ropeLengthText.text = ropeLength.ToString();
    }
    public void DecreaseRopeLength()
    {
        ropeLength -= 1;
        ropeLengthText.text = ropeLength.ToString();
    }

    public void IncreaseTargetPoints()
    {
        targetPoints++;
        targetPointsText.text = targetPoints.ToString();
    }
    public void DecreaseTargetPoints()
    {
        targetPoints--;
        targetPointsText.text = targetPoints.ToString();
    }
}
