using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Example
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Example()
        { }
    }

    public class TestItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TestItem()
        { }

        public TestItem(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
