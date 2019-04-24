using System;
using System.Collections.Generic;
using System.Linq;

namespace studentuprograma
{
    public class LinkedListUtil
    {
        public static LinkedList<Studentas> Sort(LinkedList<Studentas> LL)
        {
            LinkedList<Studentas> SortedLL = new LinkedList<Studentas>();
            List<Studentas> List = LL.ToList();
            List = List.OrderBy(x => x.Bendras).ToList();
            foreach(Studentas stud in List)
            {
                SortedLL.AddLast(stud);
            }
            return SortedLL;
        }

        public static LinkedList<Studentas> ToLinkedList(LinkedList<Studentas> LL)
        {
            LinkedList<Studentas> SortedLL = new LinkedList<Studentas>();
            List<Studentas> List = LL.ToList();
            foreach (Studentas stud in List)
            {
                SortedLL.AddLast(stud);
            }
            return SortedLL;
        }

        public static LinkedList<Studentas> AddListToLinkedList(List<Studentas> List, LinkedList<Studentas> LL)
        {
            foreach (Studentas stud in List)
            {
                LL.AddLast(stud);
            }
            return LL;
        }
    }
}
