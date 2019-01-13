using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Attempt
    {
        public enum LampPosition {Left, Right}; // Which side the lamp is on

        public List<string> result; // List of the steps to the solution

        public int total; // Total time taken if a result is found

        public Attempt (List<int> left, List<int> right, LampPosition lampPosition, int time, int target)
        {
            result = new List<string> { };
            if (Try(left, right, lampPosition, time, target))
            {
                for (var i = result.Count - 1; i> -1; i--) // Results genereated in reverse order due to recursion
                    Console.WriteLine(result.ElementAt(i));
                Console.WriteLine("Total: " + total);
            }
            else
                Console.WriteLine("No solution found.");
        }

        // Function to recursively traverse the tree of all permuations
        private Boolean Try (List<int> left, List <int> right, LampPosition lampPosition, int time, int target)
        {
            if (time > target) return false; // We've taken too long, so give up
            if (left.Count == 0) // Everyone is across and we're done
            {
                total = time;
                return true;
            }

            if (lampPosition==LampPosition.Left)
                for (var i=0; i<left.Count-1;i++)
                    for (var j = i+1; j < left.Count; j++)
                    {
                        int crossing1 = left.ElementAt(i);
                        int crossing2 = left.ElementAt(j);
                        List<int> newRight = right.ToList();
                        newRight.Add(crossing1);
                        newRight.Add(crossing2);
                        List<int> newLeft = left.ToList();
                        newLeft.RemoveAt(j);
                        newLeft.RemoveAt(i);
                        if (Try(newLeft, newRight, LampPosition.Right, time+Math.Max(crossing1,crossing2), target))
                        {
                            result.Add("->" + crossing1.ToString() + ", " + crossing2.ToString());
                            return true;
                        }
                    }
            else
                for (var i = 0; i < right.Count ; i++)
                    {
                        int crossing = right.ElementAt(i);
                        List<int> newLeft = left.ToList();
                        newLeft.Add(crossing);
                        List<int> newRight = right.ToList();
                        newRight.RemoveAt(i);
                        if (Try(newLeft, newRight, LampPosition.Left, time + crossing, target))
                        {
                            result.Add("<-" + crossing.ToString());
                            return true;
                        }
                    }

            return false; // This is where we end up if there's no possible solution.
        }
    }
}
