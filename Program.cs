using System;

namespace Classy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        private class Animal
        {
            public string _height { get; set; }
            public int _name { get; set; }

            public Animal(string height, int name)
            {
                _height = height;
                _name = name;
            }

            public void jumping()
            {
                Console.WriteLine("kangaroos like hoping");
            }

            public void Speak(string talking)
            {
                Console.WriteLine("kangaroos got buff legs {0}", _name);
                Console.WriteLine(talking);
                Console.ReadKey();
            }

            public void Think(float now1, float now2)
            {
                var outcome = (now1 * now2) / 7;
                Console.WriteLine("The outcome is: {0}", outcome);
                Console.ReadKey();
            }
        }

        private class dogs : Animal
        {
            public string _Breed { get; set; }
            public string _name { get; set; }
            public int _stamina { get; set; }

            public dogs(string name, int stamina, string Breed) : base(name, stamina)
            {
                _name = name;
                _stamina = stamina;
                _Breed = Breed;
            }

            public void bears()
            {
                Console.WriteLine("bears can be violent depend how you raise them is: {0}", _Breed);
                Console.ReadKey();
            }

            private class Cat : Animal
            {
                public int _SixToed { get; set; }
                public string _name { get; set; }

                public Cat(string name, int SixToed) : base(name, SixToed)
                {
                    _name = name;
                    _SixToed = SixToed;
                }

                public void nature()
                {
                    Console.WriteLine("there very savage");
                    foreach (int x in _name)

                        if (x == 25)
                        {
                            Console.WriteLine("they are not very obvient");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("i love animals");
                            Console.ReadKey();
                        }
                    Console.WriteLine("Cats are very savage : {0}", _name);
                    Console.ReadKey();
                }
            }
        }
    }
}



