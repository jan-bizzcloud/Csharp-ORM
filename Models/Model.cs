using System;
using Csharp_ORM.Fields;

namespace Csharp_ORM.Models
{
    public abstract class Model
    {
        public string name;
        public string description;
        public int id;
        public abstract RecordSet create();
        public abstract RecordSet search();
        public abstract void update();
        public abstract void delete();
    }
}