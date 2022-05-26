using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{

    private bool _isPinned;
    public float _speed = 20f;
    public Rigidbody2D _rb;
    

    private void Update()
    {
        if (!_isPinned)
        {
            _rb.MovePosition(_rb.position + Vector2.up * _speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Rotater")
        {
            transform.SetParent(collision.transform);
            Score.PinCount++;
            _isPinned = true;
        }
        else if (collision.tag=="Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
          

        }

    }



}
