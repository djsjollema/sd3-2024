using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InProduct : MonoBehaviour
{
    [SerializeField] Transform A;
    [SerializeField] Transform B;
    [SerializeField] Transform C;

    [SerializeField] Arrow arrow;
    [SerializeField] Arrow w;
    [SerializeField] Arrow p;

    void Start()
    {
        
    }

    void Update()
    {
        arrow.transform.position = A.position;
        arrow.myVector = new Vector3(B.position.x - A.position.x, B.position.y - A.position.y, 0);

        w.transform.position = A.position;
        w.myVector = new Vector3(C.position.x - A.position.x, C.position.y - A.position.y, 0);
        w.myVector.Normalize();
        w.myVector = w.myVector * Vector3.Dot(arrow.myVector, w.myVector);
        p.transform.position = A.position;
        p.myVector = arrow.myVector - w.myVector;
    }
}
