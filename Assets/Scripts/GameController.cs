using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    private float _timer = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;
        Debug.Log(_timer);

        if(_timer == 0.0f)
        {
            SpawnCoin();
            _timer = 1.5f;
        }
    }

    private void CollectCoin()
    {

    }

    private void SpawnCoin()
    {
        Instantiate(_coinPrefab, Vector2.left, Quaternion.identity);
    }
}
