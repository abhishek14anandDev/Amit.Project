using System;
using System.Collections.Generic;

namespace Amit.Project.ListOperations
{
    public class ListOp
    {
        public ListOp()
        {

        }
        public List<int> AddInteger()
        {
            List<int> lint = new List<int>();
            lint.Add(12);
            lint.Add(13);
            lint.Add(78);
            lint.Add(90);
            lint.Add(78);

            return lint;

           
        }

        public List<int> RemoveIntegerFromList(List<int> lint, int itemToRemove)
        {
            lint.Remove(itemToRemove);
            return lint;
        }
        public List<int> RemovemAllitemFromList(List<int> lint, int itemToRemove)
        {

            lint.RemoveAll(t => t == itemToRemove);
            return lint;
        }
    }
}
