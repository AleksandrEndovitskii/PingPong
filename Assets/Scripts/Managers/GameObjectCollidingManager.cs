using GameObjects.Ball;
using GameObjects.Field;
using UnityEngine;

namespace Managers
{
    public class GameObjectCollidingManager : MonoBehaviour
    {
        public void Initialize()
        {
            //
        }

        public void AnalizeCollidedObjects(BallView ballView, WallView wallView)
        {
            //AnalizeCollidedObjects(BallView ballView, wallView);
        }

        public void AnalizeCollidedObjects(BallView ballView, RepellentWallView repellentWallView)
        {
            ballView.BounceInOppositeDirection();
        }

        public void AnalizeCollidedObjects(BallView ballView, GateWallView gateWallView)
        {
            //
        }
    }
}
