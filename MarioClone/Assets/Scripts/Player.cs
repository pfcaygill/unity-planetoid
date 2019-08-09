using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerControls controls;
    private Rigidbody2D rb2d;

    //Movement set values
    [SerializeField]
    private float speedMultiplier = 2f;
    [SerializeField]
    private float baseJumpForce = 250f;
    [SerializeField]
    private float torqueMultiplier = 0.5f;

    //private float CentreOfMassHeight = -0.2f;//just a bit lower to help the rotation feel natural

    public int maxJumps = 1;
    private int jumps;

    private float verticalSpeed = 0;
    private float horizontalSpeed = 0;
    private float rotation = 0;

    //State control
    private bool isTouchingPlanetoid;

    void OnEnable() { controls.gameplay.Enable(); }
    void OnDisable() { controls.gameplay.Disable(); }
    void Awake()
    {
        //Field content
        rb2d = this.GetComponent<Rigidbody2D>();
        //Usefull to change the motion and make the player fall feet downwards. instead we use manual rotation
        //rb2d.centerOfMass = new Vector3(0, CentreOfMassHeight, 0);

        RechargeJump();

        controls = new PlayerControls();
        controls.gameplay.move.performed += Move;
        controls.gameplay.move_com.performed += Skew;
        controls.gameplay.jump.performed += Jump;
        controls.gameplay.spin_anti.started += e => Torque(1f);
        controls.gameplay.spin_clock.started += e => Torque(-1f);
        controls.gameplay.spin_anti.canceled += e => Torque(0);
        controls.gameplay.spin_clock.canceled += e => Torque(0);
    }
   
    void Move(InputAction.CallbackContext e)
    {
        //For our horiz update, we want to take the left and right components for the movement
        Vector2 v = e.ReadValue<Vector2>();
        horizontalSpeed = v.x ;
    }
    void Jump(InputAction.CallbackContext e)
    {
        //For our vertic update, we want to take the jump force and apply it at a shrinking rate if the jump is active
        if (jumps > 0) verticalSpeed = baseJumpForce;
        jumps--;
    }
    void Torque(float dir) { rotation = torqueMultiplier * dir; }
    /** Our Skew vector comes from the control stick in 2D, and needs to be in 3D for this to work as expected */
    void Skew(InputAction.CallbackContext context) { rb2d.centerOfMass = new Vector3(0.5f, 0.5f, 0) * context.ReadValue<Vector2>(); }
    void Update()
    {
        if (isTouchingPlanetoid) { rb2d.AddRelativeForce(new Vector2(horizontalSpeed * speedMultiplier, verticalSpeed)); }
        if (rotation != 0) { rb2d.AddTorque(rotation); }
        //Remove the force of the jump after a short time
        verticalSpeed = 0;
    }
    public void RechargeJump() { jumps = maxJumps; }
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Planetoid"))
        {
            isTouchingPlanetoid = true;
            RechargeJump();
        }
    } 
    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Planetoid"))
        {
            isTouchingPlanetoid = false;
        }
    }
}
