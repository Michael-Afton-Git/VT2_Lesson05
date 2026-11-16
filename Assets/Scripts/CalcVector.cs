using UnityEngine;

public class CalcVector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AssetBundleLoadResult = Subtract
    }
}


public Vector3 CrossMultiply(Vector3 a, Vector3 b)
{
    var result = Vector3.zero;

    result.x = (a.y * b.z) - (a.z * b.y);
    result.y = (a.z * b.x) - (a.x * b.z);
    result.z = (a.x * b.y) - (a.y * b.x);

    //ベクトルの可視化
    Debug.DrawRay(Vector3.zero, a, Color.red, )
}