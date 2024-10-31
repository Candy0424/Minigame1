using UnityEngine;

public class MoveTest : MonoBehaviour
{
    private void Update()
    {
        InputMoveSet();
    }

    private void InputMoveSet()
    {
        if (Input.GetKeyDown(KeyCode.W))
            transform.position += (Vector3)Vector2.up;
        else if (Input.GetKeyDown(KeyCode.A))
            transform.position += (Vector3)Vector2.left;
        else if (Input.GetKeyDown(KeyCode.S))
            transform.position += (Vector3)Vector2.down;
        else if (Input.GetKeyDown(KeyCode.D))
            transform.position += (Vector3)Vector2.right;
    }   
}
