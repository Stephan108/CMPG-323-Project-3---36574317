
using System;
using System.Collections.Generic;
using System.Linq;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;


namespace DeviceManagement_WebApp.Repository
{
    public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository
    {
       
        public CategoriesRepository(ConnectedOfficeContext context) : base(context)
        {
        }
        public void Delete(Guid? CategoryId)
        {
            Category category_ = _context.Category.Find(CategoryId);
            _context.Category.Remove(category_);
        }
        public Category GetById(Guid? CategoryId)
        {
            return _context.Category.Find(CategoryId);
        }
        public IEnumerable<Category> GetAll()
        {
            return _context.Category.ToList();
        }
        public void Insert(Category category_)
        {
            _context.Category.Add(category_);
        }
        public void Update(Category category_)
        {
            _context.Category.Attach(category_);
            _context.Entry(category_).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

    }
}
