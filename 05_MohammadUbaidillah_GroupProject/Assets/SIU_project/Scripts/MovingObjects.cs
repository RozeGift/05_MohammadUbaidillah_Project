using UnityEngine;

public class MovingObjects : MonoBehaviour
{
    public Vector3[] points;
    public int pointNumber = 0;
    private Vector3 currentTarget;
    private bool ismoving;

    public float speed; //How Fast The Platform Moves
    public float delayTimer; //How Long Until The Platform Moves After Stoping
    private float delayStart;
    private float tolerance;

    //Should The Platform Move On Its Own
    public bool automatic;

    void Start()
    {
        if (points.Length > 0)
        {
            currentTarget = points[0];
        }
        tolerance = speed * Time.deltaTime;
    }

    void FixedUpdate()
    {
        if (transform.position != currentTarget)
        {
            MovePlatform();
        }
        else
        {
            UpdateTarget();
        }
    }

    //Moves To The Next Platfrom
    void MovePlatform()
    {
         if (Input.GetKey(KeyCode.E))
            {
                ismoving = true;
                print("ispressed");
                //dooranim.SetBool("IsOpen", true);
            }
        if (ismoving == true)
        {
            Vector3 heading = currentTarget - transform.position;
            transform.position += (heading / heading.magnitude) * speed * Time.deltaTime;
            if (heading.magnitude < tolerance)
            {
                transform.position = currentTarget;
                delayStart = Time.time;
            }
        }       
    }

    //Automatically Moves To Next Platform
    void UpdateTarget()
    {
        if (automatic)
        {
            if (Time.time - delayStart > delayTimer)
            {
                NextPlatform();
            }
        }
    }

    public void NextPlatform()
    {
        pointNumber++;
        if (pointNumber >= points.Length)
        {
            pointNumber = 0;
        }
        currentTarget = points[pointNumber];
    }

    //Makes The Player Stay On The Platfrom
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.parent = transform;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.parent = null;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
        }
    }
}