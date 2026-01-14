using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody2D _playerRigidbody;
    [SerializeField] private GameObject _gameController; 
    private bool _isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)  && _isGrounded == true)
        {
            _playerRigidbody.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
            _isGrounded = false;
            Debug.Log("jumped");
        }

    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if( collision.gameObject.tag == "Ground")
        {
            // Debug.Log("isGrounded");
            _isGrounded = true;
        }

        if(collision.gameObject.tag == "Coin")
        {
            Debug.Log("coin collected");
            _gameController.GetComponent<GameController>();
        }
    }


}
