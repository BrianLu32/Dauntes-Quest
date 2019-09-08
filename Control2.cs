using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

[System.Serializable]

public class Control2 : MonoBehaviour
{

    public float speed = 300.0f;
    public Rigidbody rb;
    public Text countText;
    public int count;
    public Sprite Empty, oneThird, twoThirds, Full;
    public SpriteRenderer Ice;

    void Start()
    {
        count = 0;
        SetCountText();
        Ice.sprite = Empty;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        rb.velocity = movement * speed;

        if (CollisionDetect.Hit == true)
        {
            transform.Translate((CollisionDetect.Wall.x) / 1000, 0, (CollisionDetect.Wall.z) / 1000, Space.World);
        }
    }

    void SetCountText()
    {
        countText.text = "You have " + count.ToString() + " out of 3 pieces.";
    }

    public float getVelocityX()
    {
        return rb.velocity.x;
    }
    public float getVelocityY()
    {
        return rb.velocity.y;
    }
    public float getScale()
    {
        return transform.localScale.x;
    }
    public float getCount()
    {
        return count;
    }

    public void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            switch (count)
            {
                case 1:
                    Ice.sprite = oneThird;
                    break;
                case 2:
                    Ice.sprite = twoThirds;
                    break;
                case 3:
                    Ice.sprite = Full;
                    SceneManager.LoadScene("Desert");
                    break;
            }
        }
        if(other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("Forest");
        }
    }
}
