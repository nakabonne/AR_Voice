using UnityEngine;
using System.Collections;

public class UVAnim : MonoBehaviour {

    Renderer rd;
    Vector2 dir;
    public Vector2 Direction;
    public float speed;

    void Awake()
    {
        rd = GetComponent<Renderer>();
    }
    void Update()
    {
        rd.material.SetTextureOffset("_Layer1Tex", dir += new Vector2(Time.deltaTime * speed * Direction.x, Time.deltaTime * speed * Direction.y));
    }
}
