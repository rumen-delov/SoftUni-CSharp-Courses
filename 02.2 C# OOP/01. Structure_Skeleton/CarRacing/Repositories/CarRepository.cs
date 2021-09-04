using CarRacing.Models.Cars;
using CarRacing.Repositories.Contracts;
using System.Collections.Generic;

namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<Car>
    {
        IReadOnlyCollection<Car> IRepository<Car>.Models => throw new System.NotImplementedException();

        void IRepository<Car>.Add(Car model)
        {
            throw new System.NotImplementedException();
        }

        Car IRepository<Car>.FindBy(string property)
        {
            throw new System.NotImplementedException();
        }

        bool IRepository<Car>.Remove(Car model)
        {
            throw new System.NotImplementedException();
        }
    }
}
