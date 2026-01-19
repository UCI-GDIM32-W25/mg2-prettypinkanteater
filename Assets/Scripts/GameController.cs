using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private TextMeshProUGUI _pointsText;   
    private float _timer;
    private float _randomTimeInterval;
    private float _move = 6.5f;
    [SerializeField] private GameObject _player;

    public List<GameObject> _coins = new List <GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        _randomTimeInterval = Random.Range(0f, 2f);
        _timer = _randomTimeInterval;
        Debug.Log("timer set to" + _randomTimeInterval);
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            SpawnCoin();
            _randomTimeInterval = Random.Range(0f, 2f);
            _timer = _randomTimeInterval;
        }

        foreach(GameObject coin in _coins)
        {
            coin.transform.Translate(new Vector2(-0.231f, 0) * _move * Time.deltaTime);
        }



    }

    public void CoinCollection()
    {
        _pointsText.text = "Points: " + _player.GetComponent<Player>()._points.ToString();

    }

    private void SpawnCoin()
    {
        Debug.Log("Coin spawned");
        _coins.Add(Instantiate(_coinPrefab, new Vector2(5, 1.3f), Quaternion.identity));
    }



}
