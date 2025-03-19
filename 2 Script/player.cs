using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 입력값을 받아옵니다.
        float horizontal = Input.GetAxis("Horizontal"); // A, D 키 또는 화살표 키
        float vertical = Input.GetAxis("Vertical");     // W, S 키 또는 화살표 키

        // 이동 벡터 계산 (수평, 수직)
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed;

        // Rigidbody를 이용한 이동
        rb.MovePosition(transform.position + movement * Time.fixedDeltaTime);
    }
}
