using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
  public bool isPlayerbullet;
  private GameManager gameManager;
  public float speed;
private EnemyFormation enemyFormation;
    void Start()
    {

enemyFormation= GameObject.Find("EnemyFormation").GetComponent<EnemyFormation>();
gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(0, speed * Time.deltaTime, 0);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "Enemy")
      {

        Destroy(collision.gameObject);
          enemyFormation.PlayExplosionClip();
      }
      if(collision.gameObject.tag == "Player")
      {
        Destroy(collision.gameObject);
        gameManager.RestartGame();
      }
      Destroy(gameObject);
    }
}
