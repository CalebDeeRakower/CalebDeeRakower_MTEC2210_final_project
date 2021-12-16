using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed=5;
    private SpriteRenderer sr;
public GameObject bulletPrefab;
    void Start()
    {
      sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
float xMove = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
transform.Translate(xMove, 0, 0);

        if (Input.GetKey(KeyCode.L))

        {
          transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.R))
        {
          transform.Translate(speed * Time.deltaTime, 0, 0);
        }
          if (Input.GetKeyDown(KeyCode.Space))
          {
            Shoot();
          }
        }

public void Shoot()
{
Vector3 offset = new Vector3(0,0.2f,0);
GameObject bullet=Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
    }
  }
