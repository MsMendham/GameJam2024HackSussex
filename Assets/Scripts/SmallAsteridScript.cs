using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallAsteridScript : MonoBehaviour
{
    [SerializeField] private float smashSpeed;

    [SerializeField] private Sprite[] sprites;
    [SerializeField] private Sprite[] smashSprites;
    [SerializeField] private GameObject smashPrefab;
    private SpriteRenderer SR;
    private int randomSpriteNo;

    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
        randomSpriteNo = Random.Range(0, sprites.Length);
        SR.sprite = sprites[randomSpriteNo];
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.relativeVelocity.magnitude);
            if (collision.relativeVelocity.magnitude >= smashSpeed)
            {
                GameObject piece1 = Instantiate(smashPrefab, transform.position, new Quaternion(0, 0, 0, 0));
                GameObject piece2 = Instantiate(smashPrefab, transform.position, new Quaternion(0, 0, 0, 0));
                GameObject piece3 = Instantiate(smashPrefab, transform.position, new Quaternion(0, 0, 0, 0));
                switch (randomSpriteNo)
                {
                    case 0:
                        
                        piece1.GetComponent<SpriteRenderer>().sprite = smashSprites[0];
                        piece1.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-1, 1)*5);
                        
                        piece2.GetComponent<SpriteRenderer>().sprite = smashSprites[1];
                        piece2.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-1, -1)*5);
                        
                        piece1.GetComponent<SpriteRenderer>().sprite = smashSprites[2];
                        piece1.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(1, 0)*5);
                        break;
                    case 1:
                        piece1.GetComponent<SpriteRenderer>().sprite = smashSprites[15];
                        piece1.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-1, 1)*5);

                        piece2.GetComponent<SpriteRenderer>().sprite = smashSprites[16];
                        piece2.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-1, -1)*5);

                        piece1.GetComponent<SpriteRenderer>().sprite = smashSprites[17];
                        piece1.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(1, 0)*5);
                        break;
                    case 2:
                        piece1.GetComponent<SpriteRenderer>().sprite = smashSprites[3];
                        piece1.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-1, 1)*5);

                        piece2.GetComponent<SpriteRenderer>().sprite = smashSprites[4];
                        piece2.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-1, -1)*5);

                        piece1.GetComponent<SpriteRenderer>().sprite = smashSprites[5];
                        piece1.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(1, 0)*5);
                        break;
                    case 3:
                        piece1.GetComponent<SpriteRenderer>().sprite = smashSprites[6];
                        piece1.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-1, 1)*5);

                        piece2.GetComponent<SpriteRenderer>().sprite = smashSprites[7];
                        piece2.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-1, -1)*5);

                        piece1.GetComponent<SpriteRenderer>().sprite = smashSprites[8];
                        piece1.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(1, 0)*5);
                        break;
                    case 4:
                        piece1.GetComponent<SpriteRenderer>().sprite = smashSprites[12];
                        piece1.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-1, 1)*5);

                        piece2.GetComponent<SpriteRenderer>().sprite = smashSprites[13];
                        piece2.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-1, -1)*5);

                        piece1.GetComponent<SpriteRenderer>().sprite = smashSprites[14];
                        piece1.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(1, 0)*5);
                        break;
                    case 5:
                        piece1.GetComponent<SpriteRenderer>().sprite = smashSprites[9];
                        piece1.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-1, 1)*5);

                        piece2.GetComponent<SpriteRenderer>().sprite = smashSprites[10];
                        piece2.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-1, -1)*5);

                        piece1.GetComponent<SpriteRenderer>().sprite = smashSprites[11];
                        piece1.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(1, 0)*5);
                        break;

                }
                collision.collider.GetComponent<Rigidbody2D>().velocity = collision.relativeVelocity*0.6f;
                Destroy(this.gameObject);
            }
        }
    }
}
