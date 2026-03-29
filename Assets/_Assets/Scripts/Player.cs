using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W)) { inputVector.y = +1; }
        if (Input.GetKey(KeyCode.S)) { inputVector.y = -1; }
        if (Input.GetKey(KeyCode.A)) { inputVector.x = -1; }
        if (Input.GetKey(KeyCode.D)) { inputVector.x = +1; }
        Vector3 normalized = inputVector.normalized;

        transform.position += new Vector3(normalized.x, 0, normalized.y) * moveSpeed * Time.deltaTime;
    }
}