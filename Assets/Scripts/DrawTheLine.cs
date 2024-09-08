using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawTheLine : MonoBehaviour
{
    public LineRenderer f_l;
    LinearFunction f;
    Vector2 minRange,maxRange;
    public Transform A, B;
    // Start is called before the first frame update
    void Start()
    {
        f = new LinearFunction();
        minRange = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxRange = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        f.SetFunctionWithTwoPoints(A.position, B.position);
        f_l.SetPosition(0, new Vector3(minRange.x, f.getY(minRange.x),0));
        f_l.SetPosition(1, new Vector3(maxRange.x, f.getY(maxRange.x), 0));
    }
}
