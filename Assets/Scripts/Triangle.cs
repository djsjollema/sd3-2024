using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    [SerializeField] Transform A, B, C;
    [SerializeField] LineRenderer AB, AC, BC;

    LinearFunction ab = new LinearFunction();
    LinearFunction ac = new LinearFunction();
    LinearFunction bc = new LinearFunction();
    
    
 void Update()
    {
        drawLine(ab, AB, A.position, B.position);
        drawLine(bc, BC, B.position, C.position);
        drawLine(ac, AC, A.position, C.position);
    }

void drawLine(LinearFunction lf, LineRenderer lr, Vector3 P0, Vector3 P1)
    {
        lf.setFunctionWithTwoPoints(P0, P1);
        lr.SetPosition(0, new Vector3(-10, lf.getY(-10), 0));
        lr.SetPosition(1, new Vector3(10, lf.getY(10), 0));
    }
}
