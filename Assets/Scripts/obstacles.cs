using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class obstacles : MonoBehaviour
{
    public UnityEvent OnObstacleCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("cleaner"))
        {
            GManager.Instance.score += 1;
            GManager.Instance.obstacles -= 1;
            OnObstacleCollision.Invoke();
            Destroy(gameObject, 0.5f);
        }
    }
}
