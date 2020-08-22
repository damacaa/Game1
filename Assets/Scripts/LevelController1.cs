using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelController1 : LevelController
{
    public Camera cam;
    CameraFollows camF;

    public GameObject screenControls;

    public GameObject prefab;

    public LayerMask playerLayer;
    public LayerMask enemyLayer;

    public TextMeshProUGUI text;

    public int range;

    public PlayerController p1;
    public PlayerController p2;

    PlayerControls controls;
    Vector2 move1;
    Vector2 move2;

    int points1 = -1;
    int points2 = -1;


    // Start is called before the first frame update
    void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        AllowScreenRotation(false);

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

    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (p1)
        {
            p1.Move(move1);

            bool inside = Vector3.Distance(p1.transform.position, Vector3.zero) < 2*range;

            if(!inside) { p1.Die(); }
        }
        else
        {
            GameObject newPlayer = GameObject.Instantiate(prefab, new Vector3(UnityEngine.Random.Range(-range,range), UnityEngine.Random.Range(-range, range), 0), Quaternion.identity);
            newPlayer.layer = 8;
            newPlayer.name = "Dani";
            p1 = newPlayer.GetComponent<PlayerController>();
            p1.layerMask = enemyLayer;
            points2++;
            camF.players[0] = newPlayer;
        }

        if (p2)
        {
            p2.Move(move2);

            bool inside = Vector3.Distance(p2.transform.position, Vector3.zero) < 2 * range;

            if (!inside) { p2.Die(); }
        }
        else
        {
            GameObject newPlayer = GameObject.Instantiate(prefab, new Vector3(UnityEngine.Random.Range(-range, range), UnityEngine.Random.Range(-range, range), 0), Quaternion.identity);
            newPlayer.layer = 9;
            newPlayer.name = "Juanje";
            p2 = newPlayer.GetComponent<PlayerController>();
            p2.layerMask = playerLayer;
            points1++;
            camF.players[1] = newPlayer;
        }

        text.text = points1 + ":" + points2;
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

    public override void Shake()
    {
    }

    public void HideHud()
    {
        screenControls.SetActive(!screenControls.activeSelf);
    }
}
