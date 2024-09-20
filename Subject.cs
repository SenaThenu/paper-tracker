using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTracker
{
    internal class Subject
    {
        public string name;
        public List<Topic> topics = new();

        public Subject(string subName)
        {
            name = subName;
        }

        public void AddTopic(Topic newTopic)
        {
            topics.Add(newTopic);
        }

        public void RemoveTopicsByIndex(List<int> indexList)
        {
            indexList.Sort();
            int offset = 0; // how many indices are deviated once an element is removed

            foreach (int index in indexList)
            {
                if ((index - offset) < topics.Count)
                {
                    topics.RemoveAt(index - offset);
                    offset += 1;
                }
                else
                {
                    Console.Error.WriteLine("Invalid topic index!");
                }
            }
        }
    }
}
