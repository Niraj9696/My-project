using UnityEngine;

namespace AG1935
{
    public class Rotating : MonoBehaviour
    {


        [SerializeField] private float rotationSpeed = 60f;// Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f);
        }
    }

}