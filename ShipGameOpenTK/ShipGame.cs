using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace ShipGameOpenTK
{
    class ShipGame : GameWindow
    {
        public ShipGame() : base(){}

        protected override void OnUpdateFrame(FrameEventArgs e){
            
        }
        protected override void OnRenderFrame(FrameEventArgs e){
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(Color.CornflowerBlue);


            GL.Begin(PrimitiveType.Triangles);
            GL.Vertex3(0,1,0);
            GL.Vertex3(-1,-1,0);
            GL.Vertex3(1,-1,0);
            GL.End();

            SwapBuffers();
        }

    }
}
