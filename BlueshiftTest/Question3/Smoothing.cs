using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Smoothing
    {
        public List<float> s;

        // Smoothing function
        public Smoothing(List<float> x, int p, float alpha)
        {
            // Calculate the first element and add it to the List.
            float s1 = 0;
            for (int i = 0; i < p; i++)
                s1 = s1 + x.ElementAt(i) / p;
            s = new List<float> { Math.Max(s1,0) };

            // Calculate the remaining elements.
            for (int i = 1; i < x.Count(); i++)
            {
                float st = Math.Max(alpha * x.ElementAt(i) + (1 - alpha) * s.ElementAt(i - 1),0);
                s.Add(st);
            }
        }

    }
}
