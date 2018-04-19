using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace ShipGameOpenTK
{
    class ShipGame : GameWindow
    {
        Matrix4 pro, view, model;
        Camera cam;
        Ship s;
        ParticleManager pMan;

        public ShipGame() : base(400,600){}

        protected override void OnLoad(EventArgs e)
        {
            pro = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.PiOver4, (float)this.Width / this.Height,
                1, 100);
            cam = new Camera(new Vector3(0, 0, 5),
                new Vector3(0, 0, 0),
                new Vector3(0, 1, 0));
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref pro);
            pMan = new ParticleManager();

            s = new Ship();
        }

        protected override void OnUpdateFrame(FrameEventArgs e){
            s.ManageKeyEvent();
            pMan.updateGenerate();
            
            pMan.update();
        }


        protected override void OnRenderFrame(FrameEventArgs e){
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(Color.Black);

            s.draw(cam.getView());
            this.Title = s.Position.ToString();
            pMan.draw(cam.getView());

            SwapBuffers();
        }

    }
}
