using UnityEngine;

    namespace AG1935
{
    public class Jigjag : MonoBehaviour

    {
        public float bounceHeight = 3f;
        public float bounceSpeed = 2f;
        public float Horizontallength = 2f;
        public float Speed = 2f;

        private Vector3 startPos;
        private float currentY;
        private float currentX;

        void Start()
        {
            startPos = transform.position;
        }

        void Update()
        {
            // Calculate vertical position using sine wave for smooth bouncing
            currentY = Mathf.PingPong(Time.time * bounceSpeed, bounceHeight);
            currentX = Mathf.PingPong(Time.time * Speed, Horizontallength);
            transform.position = startPos + new Vector3(currentX, currentY, 0);
        }
    } 
}
