using System;
using System.Collections.Generic;

namespace NHibernate_Sample.Model
{
    public class Hero
    {
        private ICollection<Profession> _profession;

        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int MP { get; set; }
        public virtual int HP { get; set; }
        public virtual ICollection<Profession> Profession
        {
            get { return _profession; }
            set { _profession = value; }
        }

        public virtual void Add(Profession profession)
        {
            if (_profession == null)
            {
                _profession = new List<Profession>();
            }
            profession.Hero = this;
            _profession.Add(profession);
        }
    }
}
