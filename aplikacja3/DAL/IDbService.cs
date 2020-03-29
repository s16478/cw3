using System;
using System.Collections.Generic;
using aplikacja3.Models;

namespace aplikacja3.DAL
{
    public interface IDbService
    {

        public IEnumerable<Student> GetStudents();

    }
}
