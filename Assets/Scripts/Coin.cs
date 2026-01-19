using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject _gameController;

    // Start is called before the first frame update
    void Start()
    {
        _gameController = GameObject.Find("GameSystem");
       if(_gameController != null)
        {
            Debug.Log("Game Controller Found");
            // game controller cannot be made as a reference bc it is a prefab...
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<Transform>().position.x < -0.32f)
        {
            _gameController.GetComponent<GameController>()._coins.Remove(gameObject);
            
            Destroy(gameObject);
        }
    }

    public void KillSelf()
    {
        Destroy(gameObject);
    }


}
