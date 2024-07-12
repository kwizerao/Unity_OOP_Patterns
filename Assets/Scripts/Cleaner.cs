using Unity.VisualScripting;
using UnityEngine;


[RequireComponent (typeof(Rigidbody))]
public class Cleaner : MonoBehaviour
{
    public int Speed = 100;


    private Rigidbody rb;
    private Vector3 Movements = Vector3.zero;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movements.x = Input.GetAxisRaw("Horizontal");
        Movements.z = Input.GetAxisRaw("Vertical");
        rb.AddForce(Movements * Speed, ForceMode.Force);
    }

}
