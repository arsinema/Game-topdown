using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] int speed = 100;
    private Rigidbody rb;
    Vector3 dir = new Vector3();

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        dir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            rb.MovePosition(new Vector3(dir.x, dir.y, 0));

        }
    }
}
