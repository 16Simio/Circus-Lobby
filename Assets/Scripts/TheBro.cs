using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class TheBro : MonoBehaviour
{
    public SplineContainer spline;

    float splineLenght;

    public float speed = 10f;

    float distancePercentage = 0f;
    public bool move = true;

    private void Awake()
    {
        splineLenght = spline.CalculateLength();
    }
    private void Update()
    {
        if (move)
            Move();
    }
    private void Move()
    {
        distancePercentage += speed * Time.deltaTime / splineLenght;
        Vector3 currentPosition = spline.EvaluatePosition(distancePercentage);
        transform.position = currentPosition;
        print(distancePercentage);

        if (distancePercentage >= 0.5f)
        {
            distancePercentage = 0f;
            //GamePlayManager.instance.FinishGameClientRpc();
            move = false;
        }

        Vector3 nextPosition = spline.EvaluatePosition(distancePercentage + 0.005f);

        Vector3 direction = nextPosition - currentPosition;

        //transform.rotation = Quaternion.LookRotation(direction, transform.up);
    }
}
