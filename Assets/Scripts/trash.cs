using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class trash : MonoBehaviour
{
    public UnityEvent OnTrashCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("cleaner"))
        {
            GManager.Instance.score += 1;
            GManager.Instance.trash -= 1;
            OnTrashCollision.Invoke();
            Destroy(gameObject, 0.5f);
        }
    }
}
