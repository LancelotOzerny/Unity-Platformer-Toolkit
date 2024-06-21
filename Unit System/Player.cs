using UnityEngine;

namespace LancyStudio.Platformer2D
{
    public class Player : Unit
    {
        void Update()
        {
            MoveDirection = new Vector2(
                Input.GetAxisRaw("Horizontal"),
                Input.GetAxisRaw("Vertical")
            );
        }
    }
}