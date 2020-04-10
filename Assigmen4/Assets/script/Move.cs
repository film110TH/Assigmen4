using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody rb;
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(h, 0, 0);
    }
}
