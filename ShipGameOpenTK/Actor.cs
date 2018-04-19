using System;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace ShipGameOpenTK
{
    abstract class Actor
    {
        Vector3 position;
        Vector3 velocity;
        float speed;
        float angle;
        float angleInc;
        float scale;

        public Vector3 Position { get => position; set => position = value; }
        public Vector3 Velocity { get => velocity; set => velocity = value; }
        public float Speed { get => speed; set => speed = value; }
        public float Scale { get => scale; set => scale = value; }
        public float Angle { get => angle; set => angle = value; }
        public float AngleInc { get => angleInc; set => angleInc = value; }

        public abstract void update();
        public abstract void draw(Matrix4 view);
    }
}
