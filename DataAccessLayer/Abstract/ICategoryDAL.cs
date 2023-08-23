﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface ICategoryDAL
    {
        void Insert(Category p);

        void Delete(Category p);

        void Update(Category p);

        List<Category> GetList();
    }
}
