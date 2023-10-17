using System;

namespace NHibernate_Sample.Model
{
    public class Profession
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Money { get; set; }

        public virtual Hero Hero { get; set; }
    }
}
