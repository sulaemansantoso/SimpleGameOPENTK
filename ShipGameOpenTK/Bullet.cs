using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Drawing;

namespace ShipGameOpenTK
{
    internal class Bullet : Particle
    {
        Bitmap bTexture;

        public Bullet(Vector3 position, Vector3 target, float speed ) : base(position,target,speed)
        {
            this.Ttl = 120;
            this.Scale = 0.2f;
            AngleInc = 0;
        }

        
    }
}
