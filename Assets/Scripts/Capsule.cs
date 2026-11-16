using UnityEngine;

public class Capsule : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //ひたすら前進
    Vector3 velocity = transform.forward; //カプセルの進行方向

    //"進行方向"と"法線"の外積=進行方向に右向きのベクトル
    Vector3 right = Vector3.Cross(Velocity, h\it.normal);

    //"右向きのベクトル"と"法線"の外積=スロープのベクトル
    Vector3 slope = Vector3.Cross(right, hit.normal);


}
