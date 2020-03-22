using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new IndexedNames();
            names[0] = "hello1";
            names[1] = "hello2";
            names[2] = "hello3";
            names[3] = "hello4";
            names[4] = "hello5";
            names[5] = "hello6";
            names[6] = "hello7";
            names[7] = "hello8";
            names[8] = "hello9";
            names[9] = "hello10";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine(names["hello1"]);
            Console.WriteLine(names["hello2"]);
            Console.WriteLine(names["hello3"]);
            Console.WriteLine(names["hello4"]);
            Console.WriteLine(names["hello99"]);
            Console.ReadLine();
        }
    }

    /// <summary>
    /// 索引器
    /// </summary>
    class IndexedNames
    {
        private string[] nameList = new string[10];

        public IndexedNames()
        {
            for (int i = 0; i < nameList.Length; i++)
            {
                nameList[i] = "N/A";
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= nameList.Length)
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = string.Empty;
                }

                return tmp;
            }

            set
            {
                if (index >= 0 && index < nameList.Length)
                {
                    nameList[index] = value;
                }
            }
        }

        /// <summary>
        /// 索引器的重载
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int this[string name]
        {
            get
            {
                int index = 0;

                while (index < nameList.Length)
                {
                    if (nameList[index].Equals(name))
                    {
                        return index;
                    }
                    index++;
                }
                return -1;
            }
        }
    }
}
