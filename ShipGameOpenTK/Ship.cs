using System;
using System.Collections.Generic;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace ShipGameOpenTK
{
    class Ship : Actor
    {
        public BulletManager bManager;
        float bDelay = 5;
        public Ship()
        {
            Position = new Vector3(0,-1.5f, 0);
            Speed = 0.1f;
            Scale = 0.1f;
            bManager = new BulletManager();
        }

        public override void draw(Matrix4 view)
        {

            Matrix4 model = Matrix4.Identity;
            this.Angle += AngleInc;
            model = Matrix4.Mult(model, Matrix4.CreateRotationZ(Angle));
            model = Matrix4.Mult(model, Matrix4.CreateScale(Scale));
            model = Matrix4.Mult(model, Matrix4.CreateTranslation(Position));
            model = Matrix4.Mult(model, view);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref model);
            GL.Color3(Color.Red);
            GL.Begin(PrimitiveType.Triangles);
            GL.Vertex3(0, 1, 0);
            GL.Vertex3(-1, -1, 0);
            GL.Vertex3(1, -1, 0);
            GL.End();

            bManager.draw(view);
        }

        public void ManageKeyEvent()
        {
            KeyboardState kstate = Keyboard.GetState();
            Velocity = new Vector3(1, 0, 0) * Speed;
            if (kstate.IsKeyDown(Key.D))
            {
                if (Position.X < 1.4f) {
                    Position += Velocity;
                }
            }
            if (kstate.IsKeyDown(Key.A) )
            {
                if (Position.X > -1.4f)
                {
                    Position -= Velocity;
                }
            }
            if (kstate.IsKeyDown(Key.Space))
            {
                float bSpeed = 0.1f;
                if (bDelay <0)
                {
                    bDelay = 0.5f;
                    Bullet temp = new Bullet(this.Position, new Vector3(0, 1, 0), bSpeed);
                    temp.Scale = 0.05f;
                   
                    bManager.AddBullet(temp);
                }
                else
                {
                   
                }
            }
            bDelay -= 0.1f;
            bManager.update();
        }

        public override void update()
        {
            

        }
    }
}
