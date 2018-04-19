using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace ShipGameOpenTK
{
    class Particle : Actor
    {
        float ttl;

        public float Ttl { get => ttl; set => ttl = value; }

        public Particle(Vector3 position, Vector3 velocity, float speed)
        {
            Position = position;
            Velocity = velocity;
            Speed = speed;
            AngleInc = 0.1f;
        }

        public override void draw(Matrix4 view)
        {
            //draw something here 
            Matrix4 model = Matrix4.Identity;
            this.Angle += AngleInc;
            model = Matrix4.Mult(model, Matrix4.CreateRotationX(Angle));
            model = Matrix4.Mult(model, Matrix4.CreateScale(Scale));
            model = Matrix4.Mult(model, Matrix4.CreateTranslation(Position));
            model = Matrix4.Mult(model, view);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref model);
            GL.Color3(Color.White);
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(1, 1, 0);
            GL.Vertex3(1, -1, 0);
            GL.Vertex3(-1, -1, 0);
            GL.Vertex3(-1, 1, 0);
            GL.End();
        }

        public override void update()
        {
            ttl--;
            Position += Velocity * Speed;
        }
    }
}
