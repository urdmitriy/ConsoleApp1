using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_5
{
    class ToDo
    {
        public string Title { get; set; }
        public bool isDone { get; set; }

        public ToDo()
        {
            Title = "";
            isDone = false;
        }

        public ToDo(string title)
        {
            Title = title;
            isDone = false;
        }

        public string getTitle()
        {
            return Title;
        }

        public void setTitle(string title)
        {
            Title = title;
        }

        public void setDone()
        {
            isDone = true;
        }

        public bool getIsDone()
        {
            return isDone;
        }
    }
}
