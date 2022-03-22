using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MotionCube : MonoBehaviour
{
    [SerializeField] private float speed = 10F;
    [SerializeField] private float cubeLife = 5F;
    public Vector3 direction;
    public Rigidbody rigidBody;
    public Text mySecondTextLabel;
    public Text myThirdTextLabel;

    private void Update()
    {
        rigidBody.velocity = direction;
        direction = Vector3.forward;
        direction *= speed;
        Destroy(gameObject, cubeLife);
    }

    private void Start()
    {
        mySecondTextLabel.text = "Speed = " + speed;
        myThirdTextLabel.text = "Distance = " + cubeLife;
    }
}
