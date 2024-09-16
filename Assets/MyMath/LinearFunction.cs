using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearFunction 
{
    public float slope = 1.0f;
    public float intercept = 0.0f;

    public float getY(float x)
    {
        return x * this.slope + this.intercept;
    }

    public void setFunctionWithTwoPoints(Vector3 A, Vector3 B)
    {
        this.slope = (B.y - A.y) /(B.x - A.x);
        this.intercept = B.y - this.slope * B.x;
    }
}
