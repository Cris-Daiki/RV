using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalMove;
    public float VerticalMove;
    private Vector3 playerInput;
    public CharacterController player;


    public float PlayerSpeed;
    private Vector3 MovePlayer;

    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxis("Horizontal");
        VerticalMove = Input.GetAxis("Vertical");

        //cerca el movimiento del personaje sin salirse de los limites
        playerInput = new Vector3(HorizontalMove, 0, VerticalMove);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        // camara

        CamDirection();

        MovePlayer = playerInput.x * camRight + playerInput.z * camForward;

        player.Move(MovePlayer * PlayerSpeed * Time.deltaTime);


    }

    void CamDirection()
    {
        //limita el movimiento del jugador segun la posicion de la camara
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;

    }




}
