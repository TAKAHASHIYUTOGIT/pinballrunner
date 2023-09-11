using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float m_movePower = 5f;
    float m_h;//…•½•ûŒü‚Ì“ü—Í’l
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Vector2 velocity = _rb.velocity;
        velocity.x = m_h * m_movePower;
        _rb.velocity = velocity;
    }
    private void FixedUpdate()
    {
        _rb.AddForce(Vector2.right * m_h * m_movePower, ForceMode2D.Force);
    }
    void Update()
    {
        m_h = Input.GetAxisRaw("Horizontal");
    }
}
