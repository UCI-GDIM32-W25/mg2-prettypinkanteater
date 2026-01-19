using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCoin : MonoBehaviour
{
    [SerializeField] private GameObject _gameController;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            _gameController.GetComponent<GameController>()._coins.Remove(collision.gameObject);
            collision.gameObject.GetComponent<Coin>().KillSelf();
        }
    }
}
