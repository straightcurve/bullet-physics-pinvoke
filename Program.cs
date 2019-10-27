using System;
using System.Collections.Generic;
using BulletSharp;
using BulletSharp.Math;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new BulletSharp.DefaultCollisionConfiguration();
            var dispatcher = new BulletSharp.CollisionDispatcher(config);
            var pair = new BulletSharp.DbvtBroadphase();
            var world = new BulletSharp.CollisionWorld(dispatcher, pair, config);

            var players = new Dictionary<Guid, RigidBody>();

            var ci = new RigidBodyConstructionInfo(1, new DefaultMotionState(), new SphereShape(.513037f));
            var rb = new RigidBody(ci);
            rb.Gravity = Vector3.Zero;
            rb.Translate(new Vector3(0f, 1.5f, 0f));
            world.AddCollisionObject(rb);
        }
    }
}
