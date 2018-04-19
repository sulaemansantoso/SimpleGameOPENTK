using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace ShipGameOpenTK
{
    class ParticleManager
    {
        List<Particle> pList;
        Vector3 position;
        Random r;

        public ParticleManager()
        {
            pList = new List<Particle>();
            r = new Random();
            //must generate particle awal 
            for (int i=0;i<100;i++)
            {
                float y = r.Next(-300, 300) * 0.01f;
                generate(new Vector3(0,y,0));
            }

      
            position = new Vector3(0, 2, 0);
        }

        public void generate(Vector3 curPos)
        {
            float x = r.Next(-200, 200) * 0.01f;
            Vector3 pPos = curPos + new Vector3(x, 0, 0);
            float speed = r.Next(1, 10) * 0.01f;
            Particle p = new Particle(pPos, new Vector3(0, -1, 0), speed);
            p.Scale = r.Next(1, 5) * 0.002f;
            p.Ttl = r.Next(200, 300);
            pList.Add(p);
        }

        public void updateGenerate()
        {
            int generate = r.Next(0, 10);
            if (generate > 3)
            {
                int generate2 = r.Next(0, 10);
                for (int i=0;i<generate2;i++)
                {
                    this.generate(this.position);
                }
            }
        }

        public void update()
        {
            for (int i=0;i<pList.Count;i++)
            {
                if (pList[i].Ttl >0)
                {
                    pList[i].update();
                }
                else
                {
                    pList.RemoveAt(i);
                    i--;
                }
            }
        }

        public void draw(Matrix4 view)
        {
            foreach (Particle p in pList)
            {
                p.draw(view);
            }
        }

    }

}
