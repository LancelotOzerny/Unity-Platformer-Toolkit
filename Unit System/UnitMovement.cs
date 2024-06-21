using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class UnitMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody2D = null;
    public Vector2 MoveDirection
    {
        get;
        protected set;
    }

    public Vector2 Velocity
    {
        get => rigidBody2D.velocity;
        protected set => rigidBody2D.velocity = value;
    }

    [Header("Jump Settings")]
    [SerializeField] private LayerContactChecker isGrounded = null;
    [SerializeField] private float jumpPower = 12.0f;

    [Header("Movement Settings")]
    [SerializeField] private float movementSpeed = 4.0f;

    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (rigidBody2D == null)
        {
            Debug.LogWarning($"RigidBody2D is't added to { name }");
            return;
        }

        Velocity = new Vector2(MoveDirection.x * movementSpeed, Velocity.y);
        
        if (MoveDirection.y > 0)
        {
            Jump();
        }
    }

    public void Jump()
    {
        if (isGrounded.IsContactedWithLayer())
        {
            Velocity = new Vector2(Velocity.x, jumpPower);
        }
    }
}
