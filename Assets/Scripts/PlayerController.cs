using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int number = 0;
    string player = "big";
    bool isPlayer = false;
    public string grade = "A";
    public float speed = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(player);
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = gameObject.GetComponent<Transform>();
        t.Translate(0, 0, speed * Time.deltaTime);
        //t.Translate(Vector3.forward * speed * time.deltatime);
        //t.Translate( speed * time.deltatime * Vector3.forward);
    }
}
