using LiteDB;
using ModelPatZyg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   
    public class LiteRepository 
        {
        public static string  Connection = @"C:\tmp\toys";
        private readonly string toysConnection = Connection;
            public List<Toy> GetAll()
            {
                using (var db = new LiteDatabase(this.toysConnection))
                {
                    var repository = db.GetCollection<ToyDB>("toys");
                    var results = repository.FindAll();

                    return results.Select(x => Map(x)).ToList();
                }
            }

            public int Add(Toy toy)
            {
                using (var db = new LiteDatabase(this.toysConnection))
                {
                    var dbObject = InverseMap(toy);

                    var repository = db.GetCollection<ToyDB>("toys");
                    if (repository.FindById(toy.Id) != null)
                        repository.Update(dbObject);
                    else
                        repository.Insert(dbObject);

                    return dbObject.Id;
                }
            }

            public Toy Get(int id)
            {
                using (var db = new LiteDatabase(this.toysConnection))
                {
                    var repository = db.GetCollection<ToyDB>("toys");
                    var result = repository.FindById(id);
                    return Map(result);
                }
            }

            public Toy Update(Toy toy)
            {
                using (var db = new LiteDatabase(this.toysConnection))
                {
                    var dbObject = InverseMap(toy);

                    var repository = db.GetCollection<ToyDB>("toys");
                    if (repository.Update(dbObject))
                        return Map(dbObject);
                    else
                        return null;
                }
            }

            public bool Delete(int id)
            {
                using (var db = new LiteDatabase(this.toysConnection))
                {
                    var repository = db.GetCollection<ToyDB>("toys");
                    return repository.Delete(id);
                }
            }
        

            internal Toy Map(ToyDB toyDb)
            {
                if (toyDb == null)
                    return null;
                return new Toy() { Id = toyDb.Id, Name = toyDb.Name,Price = toyDb.Price,Value = toyDb.Value};
            }

        internal ToyDB InverseMap(Toy toyDb)
        {
            if (toyDb == null)
                return null;
            return new ToyDB() { Id = toyDb.Id, Name = toyDb.Name, Price = toyDb.Price, Value = toyDb.Value };
        }
    }
    }


