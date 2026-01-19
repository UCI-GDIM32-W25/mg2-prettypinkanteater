using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody2D _playerRigidbody;
    [SerializeField] private GameObject _gameController; 
    private bool _isGrounded;
    public int _points;

    // Start is called before the first frame update
    void Start()
    {
        _points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)  && _isGrounded == true)
        {
            _playerRigidbody.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
            _isGrounded = false;
            // Debug.Log("jumped");
        }

    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            // Debug.Log("isGrounded");
            _isGrounded = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Debug.Log("coin collected and coin death");
            // collision.gameObject.GetComponent<Coin>().KillSelf();
            // need to make this occur for individual coins. not all. 
            _points++;
            _gameController.GetComponent<GameController>().CoinCollection();
            _gameController.GetComponent<GameController>()._coins.Remove(collision.gameObject);
            collision.gameObject.GetComponent<Coin>().KillSelf();
           
        }
      
    }


}
