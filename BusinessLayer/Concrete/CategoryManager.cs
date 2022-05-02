﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void CategoryAdd(Category p)
        {
            _categorydal.Insert(p);
        }

        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);
        }
        //Gunlelle
        public void CategoryUpdate(Category category)
        {
            _categorydal.Update(category);  
        }

        public Category GetByID(int id)
        {
            return _categorydal.Get(x => x.CategoryID == id);
        }
        public List<Category> GetList()
        {
            return _categorydal.List();
        }

        // GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAll()
        //{
        //    return repo.List();
        //}
        //public void CategoryAdd(Category p)
        //{

        //    if (p.CategoryName == "" || p.CategoryName.Length <=3 ||
        //        p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //    {
        //        // Hata mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}


    }
}