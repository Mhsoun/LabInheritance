using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class RandomList : List<string>
    {


        public string ReturnRandom(List<string> randomString)
        {
            var rand = new Random();
            var randIndex = rand.Next(0, randomString.Count());
            return randomString[randIndex];
        }
        public void RemoveRandom(List<string> randomString)
        {
            var rand = new Random();
            var randIndex = rand.Next(0, randomString.Count());
            randomString.RemoveAt(randIndex);
        }
    }
}
