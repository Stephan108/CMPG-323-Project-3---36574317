using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {
        
        IEnumerable<Category> GetAll();
        Category GetById(Guid? CategoryId);
        void Insert(Category category_);
        void Update(Category category_);
        void Delete(Guid? CategoryId);
        
    }
}
