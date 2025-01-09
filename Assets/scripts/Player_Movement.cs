using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] int speed = 100;
    private NavMeshAgent agent;
    private Rigidbody rb;
    Vector3 dir = new Vector3();

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        agent = GetComponent<NavMeshAgent>();
        agent.updateUpAxis = false;
        agent.updateRotation = false;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        agent.SetDestination(dir);
    }
}
