using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;
    
    Vector2 movementInput;
    Rigidbody2D rb;
    List<RaycastHit2D> castCollision = new List<RaycastHit2D>();

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        // If movement input is not 0, dont move.
        if (movementInput != Vector2.zero) {
            // Try move the player in the direction they want.
            bool moved = TryMove(movementInput);
            // If they are not able to move, test x and y separately. 
            // This allows for a player to move up a wall if they are
            // right up against it.
            if (!moved) {
                // Try for X
                moved = TryMove(new Vector2(movementInput.x, 0));
                if (!moved) {
                    // Try for Y
                    TryMove(new Vector2(0, movementInput.y));
                }
            }
        }
    }


    private bool TryMove(Vector2 direction) {
        int count = rb.Cast(
                direction,
                movementFilter,
                castCollision,
                moveSpeed * Time.fixedDeltaTime + collisionOffset
        );

        if (count == 0) {
            rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
            return true;
        } 
        return false;
    }

    void OnMove(InputValue movementValue) {
        movementInput = movementValue.Get<Vector2>();

    }
}
