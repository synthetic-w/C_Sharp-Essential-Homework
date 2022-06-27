namespace _01_ClassRoom.Models
{
    internal class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = p4;
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = new Pupil();
        }

        public ClassRoom(Pupil p1, Pupil p2)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = new Pupil();
            pupils[3] = new Pupil();
        }

        public void ShowPupils()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                if (pupils[i] != null)
                {
                    Console.WriteLine($"Ученик номер {i + 1}:");

                    pupils[i].Write();
                    pupils[i].Relax();
                    pupils[i].Read();
                    pupils[i].Study();
                    Console.WriteLine(new String('=', 20));
                }
            }
        }
    }
}
