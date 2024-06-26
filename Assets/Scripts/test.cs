using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class test : MonoBehaviour
{

    public int powerJump = 5000;
    public int movementSpeed = 10;
    public feet feet;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello world!");
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 currentVelocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);

        Vector3 oldScale = transform.localScale;

        if (Input.GetKey(KeyCode.D))
        {
            //gameObject.GetComponent<Transform>().localRotation = Quaternion.Euler(gameObject.GetComponent<Transform>().rotation.x, 180, gameObject.GetComponent<Transform>().rotation.z);
            currentVelocity.x += movementSpeed;
            oldScale.x = Mathf.Abs(oldScale.x);
            GetComponent<Rigidbody2D>().centerOfMass = new Vector2(-0.7f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //gameObject.GetComponent<Transform>().localRotation = Quaternion.Euler(gameObject.GetComponent<Transform>().rotation.x, 0, gameObject.GetComponent<Transform>().rotation.z);
            currentVelocity.x -= movementSpeed;
            oldScale.x = Mathf.Abs(oldScale.x) * -1;
            GetComponent<Rigidbody2D>().centerOfMass = new Vector2(0.7f,0);
        }

        transform.localScale = oldScale;

        GetComponent<Rigidbody2D>().velocity = currentVelocity;

        if (Input.GetKeyDown(KeyCode.Space) && feet.isGrounded == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1) * powerJump);
        }

        /*if (Input.GetKeyDown (KeyCode.E))
        {
            //Sprite sprite = "Circle";
            GameObject go = new GameObject("Ball");
            go.transform.position = new Vector3(0, 0, 0);
            SpriteRenderer truc = go.AddComponent<SpriteRenderer>();
            SpriteRenderer spriteRenderer = new SpriteRenderer();
            //go.AddComponent<Rigidbody2D>();
            go.AddComponent<CircleCollider2D>();
        }*/
        
    }
}
