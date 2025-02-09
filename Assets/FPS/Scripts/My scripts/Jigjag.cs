using UnityEngine;

    namespace AG1935
{
    public class Jigjag : MonoBehaviour

    {
        public float bounceHeight = 3f;
        public float bounceSpeed = 2f;

        private Vector3 startPos;
        private float currentY;

        void Start()
        {
            startPos = transform.position;
        }

        void Update()
        {
            // Calculate vertical position using sine wave for smooth bouncing
            currentY = Mathf.PingPong(Time.time * bounceSpeed, bounceHeight);
            transform.position = startPos + Vector3.up * currentY;
        }
    } 
}
