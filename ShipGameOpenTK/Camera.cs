using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace ShipGameOpenTK
{
    class Camera
    {
        Matrix4 view;

        Vector3 position;
        Vector3 target;
        Vector3 up;

        public Vector3 Position { get => position; set => position = value; }
        public Vector3 Target { get => target; set => target = value; }
        public Vector3 Up { get => up; set => up = value; }

        public Camera(Vector3 pos,Vector3 t, Vector3 u)
        {
            position = pos;
            target = t;
            up = u;
        }

        public Matrix4 getView()
        {
            view = Matrix4.LookAt(position, target, up);
            return view;
        }

    }
}
