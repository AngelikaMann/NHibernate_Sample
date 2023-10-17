using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernate_Sample.Model;

namespace NHibernate_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadNHibernateCfg();
            ///CRUD Operationen
            var repository = new HeroRepository();
            var wizard = new Hero
            {
                Name = "Jone Doe",
                HP = 100,
                MP = 100,
                // Profession = "Teacher"
            };
            var teacher = new Profession
            {
                Name = "Teacher",
                Money = 1
            };
            wizard.Add(teacher);


            ///CREATE
            repository.Add(wizard);

            ///READ
            var someone = repository.GetHeroByHP(100);

            /////UPDATE
            someone.MP = 200;
            repository.Update(someone);

            /////Delete
            //repository.Delete(someone);

        }
        public static void LoadNHibernateCfg()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Hero).Assembly);


            new SchemaExport(cfg).Execute(true, true, false);
        }


    }

}
