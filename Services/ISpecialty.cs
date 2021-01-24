using System.Collections.Generic;
using Medicine.API.Models;

namespace Medicine.API.Services
{
    public interface ISpecialty
    {
        IEnumerable<Specialty> GetAll();
        Specialty GetSpecialtyById(int id);
        void AddSpecialty(Specialty sp);
        void RemoveSpecialty(int id);
        void UpdateSpecialty(Specialty sp);
        bool ExistSpecialty(int id);
    }
}