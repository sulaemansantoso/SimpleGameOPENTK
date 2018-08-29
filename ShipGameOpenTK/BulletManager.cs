using System;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace ShipGameOpenTK
{
    class BulletManager : ParticleManager
    {
        public int Count
        {
            get { return pList.Count; }
        }

        public BulletManager() : base()
        {
            pList = new List<Particle>();
        }

        public void AddBullet(Bullet b)
        {
            this.pList.Add(b);
        }


    }
}
