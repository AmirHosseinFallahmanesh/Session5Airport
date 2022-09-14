using System;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera sina = Camera.Create();
            sina.Start();
            sina.Rotate(30);

            Console.WriteLine(sina.GetInfo());

            Camera mina =Camera.Create();
            Console.WriteLine(mina.GetInfo());
        }
    }
    class Camera
    {
         bool state;
         int angle;
        private static Camera single=null;

        public static Camera Create()
        {
            
            if (single==null)
            {
                single = new Camera();
            }
            return single;
        }

        private Camera()
        {
            state = false;
            angle=0;
        }

        public void Start()
        {
            state = true;
        }

        public void Rotate(int angle)
        {
            this.angle = angle;
        }

        public void Stop()
        {
            state = false;
            angle = 0;
        }

        public string GetInfo()
        {
            string camState = this.state ? "Camera is on" : "camera is off";
            return camState + " the angle is " + this.angle;
        }
        
    }
}
