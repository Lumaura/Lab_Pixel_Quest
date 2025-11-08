using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public Transform respawnPoint;
    public string nextLevel = "GeoLevel_2";
    private int CoinCounter = 0;
    private int _health = 3;
    private int _maxHealth = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                    string nextLevel = collision.transform.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Death":
                {
                    if (_health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                    else
                    {
                        _health--;
                        transform.position = respawnPoint.position;
                    }
                    break;
                }
            case "Coin":
                {
                    CoinCounter++;
                    Destroy(collision.gameObject);
                    break;
                }
            case "Health":
                {
                    if (_health < _maxHealth)
                    {
                        _health++;
                        Destroy(collision.gameObject);
                    }
                    break;
                }
            case "Respawn":
                {
                    respawnPoint.position = collision.transform.Find("Point").position;
                    break;
                }
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
