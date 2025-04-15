using UnityEngine;
public class StarScaling : MonoBehaviour
{
    public float speed = 8.0f; //how fast it shakes
    public float amount = 0.3f; //how much it shakes
    public Vector3 originalPos;



    void Update()
    {
        Vector3 pos = originalPos;
        pos.x += Mathf.Sin(100 + Time.time * speed) * amount;
        pos.y += Mathf.Sin(400 + Time.time * speed) * amount;
        transform.position = pos;
    }

}
