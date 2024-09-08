using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearFunction 
{ 
    public float slope = 1.0f;
    public float intercept = 1.0f;

    public float getY(float x)
    {
        return slope * x + intercept; 
    }

    public void SetFunctionWithTwoPoints(Vector3 A, Vector3 B)
    {
        this.slope = (B.y- A.y)/(B.x - A.x);
        this.intercept = A.y - this.slope * A.x;  
    }
}
