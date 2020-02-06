using GameObjects.Field;
using UnityEngine;

namespace GameObjects
{
    public class BallView : MonoBehaviour
    {
        //Get a reference to the rigidbody attached to the gameObject
        private Rigidbody _rigidbody;

        public void BounceInOppositeDirection()
        {
            var speedInYDirection = 0f;
            if (_rigidbody.velocity.y > 0f)
            {
                speedInYDirection = -8f;
            }
            else
            {
                speedInYDirection = 8f;
            }

            var speedInXDirection = 0f;
            if (_rigidbody.velocity.x > 0f)
            {
                speedInXDirection = -8f;
            }
            else
            {
                speedInXDirection = 8f;
            }

            _rigidbody.velocity = new Vector3(speedInXDirection, speedInYDirection, 0f);
        }

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();

            LaunchBall();
        }

        public void LaunchBall()
        {
            transform.position = Vector3.zero;
            _rigidbody.velocity = Vector3.zero;

            //Flip a coin, determine direction in x-axis
            var xDirection = Random.Range(0, 2);

            //Flip another coin, determine direction in y-axis
            var yDirection = Random.Range(0, 3);

            var launchDirection = new Vector3();

            //Check results of one coin toss
            if (xDirection == 0)
            {
                launchDirection.x = -8f;
            }
            if (xDirection == 1)
            {
                launchDirection.x = 8f;
            }

            //Check results of second coin toss
            if (yDirection == 0)
            {
                launchDirection.y = -8f;
            }
            if (yDirection == 1)
            {
                launchDirection.y = 8f;
            }
            if (yDirection == 2)
            {
                launchDirection.y = 0f;
            }

            //Assign velocity based off of where we launch ball
            _rigidbody.velocity = launchDirection;
        }

        private void OnCollisionEnter(Collision collision)
        {
            var wallView = collision.gameObject.GetComponent<WallView>();
            if (wallView == null)
            {
                return;
            }
            wallView.ReactOnCollisionEnter(this);

            if (collision.gameObject.name == "Left_Bat")
            {
                _rigidbody.velocity = new Vector3(13f, 0f, 0f);

                //Check if we hit lower half of the bat...
                if (transform.position.y - collision.gameObject.transform.position.y < -1)
                {
                    _rigidbody.velocity = new Vector3(8f, -8f, 0f);
                }
                //Check if we hit lower half of the bat...
                if (transform.position.y - collision.gameObject.transform.position.y > 1)
                {
                    _rigidbody.velocity = new Vector3(8f, 8f, 0f);
                }
            }

            if (collision.gameObject.name == "Right_Bat")
            {
                _rigidbody.velocity = new Vector3(-13f, 0f, 0f);

                //Check if we hit lower half of the bat...
                if (transform.position.y - collision.gameObject.transform.position.y < -1)
                {
                    _rigidbody.velocity = new Vector3(-8f, -8f, 0f);
                }
                //Check if we hit lower half of the bat...
                if (transform.position.y - collision.gameObject.transform.position.y > 1)
                {
                    _rigidbody.velocity = new Vector3(-8f, 8f, 0f);
                }
            }
        }
    }
}
