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

        protected override void OnRenderFrame(FrameEventArgs e){
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(Color.CornflowerBlue);


            SwapBuffers();
        }

    }
}
