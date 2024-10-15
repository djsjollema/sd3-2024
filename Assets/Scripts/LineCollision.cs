using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollision : MonoBehaviour
{
    [SerializeField] Ball ball;
    [SerializeField] Transform A;
    [SerializeField] Transform B;
    [SerializeField] LineRenderer AB;
    LinearFunction f = new LinearFunction();
    [SerializeField] Arrow normal;

    Vector2 min, max;

    void Start()
    {
        min = Camera.main.ScreenToWorldPoint(Vector2.zero);
        max = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    void Update()
    {
        f.setFunctionWithTwoPoints(A.position, B.position);
        AB.SetPosition(0, new Vector3(-10, f.getY(-10), 0));
        AB.SetPosition(1, new Vector3(10, f.getY(10), 0));

        float x_avg = (A.position.x + B.position.x) / 2;
        float y_avg = (A.position.y + B.position.y) / 2;

        normal.transform.position = new Vector3(x_avg, y_avg,0);
        normal.myVector = new Vector3(-1,1/f.slope,0);
        normal.myVector.Normalize();

        if (ball.transform.position.y > max.y || ball.transform.position.y < min.y)
        {
            ball.velocity = new Vector3(ball.velocity.x, -ball.velocity.y, 0);
        }

        if (ball.transform.position.x > max.x || ball.transform.position.x < min.x)
        {
            ball.velocity = new Vector3(-ball.velocity.x, ball.velocity.y, 0);
        }

        if(ball.transform.position.y > ball.transform.position.x * f.slope + f.intercept)
        {
            ball.color = Color.red;
        } else
        {
            ball.color = Color.green;
        }
    }
}
