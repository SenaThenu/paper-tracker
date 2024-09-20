﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTracker
{
    internal class Topic
    {
        public string name;
        public Dictionary<string, bool> topicPapers = new(); // key -> paperName & value -> did or not (bool)

        public Topic(string tName)
        {
            name = tName;
        }

        public void addTopicPaper(string paperName)
        {
            topicPapers[paperName] = false;
        }

        public void removeTopicPapers(List<string> paperNames)
        {
            foreach (string paperName in paperNames)
            {
                if (topicPapers.ContainsKey(paperName))
                {
                    topicPapers.Remove(paperName);
                }
            }
        }

        public void togglePaperState(string paperName)
        {
            if (topicPapers.ContainsKey(paperName))
            {
                if (topicPapers[paperName])
                {
                    topicPapers[paperName] = false;
                }
                else
                {
                    topicPapers[paperName] = true;
                }
            }
            else
            {
                Console.Error.WriteLine("Error: Invalid paper name!");
            }
        }
    }
}
