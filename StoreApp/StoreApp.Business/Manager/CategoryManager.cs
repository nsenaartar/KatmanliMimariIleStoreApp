using StoreApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Entity;
using StoreApp.DataAccess.Abstract;
using StoreApp.DataAccess.Concrete.EntityFramework;

namespace StoreApp.Business.Manager
{
    public class CategoryManager : ICategoryManager
    {
        ICategoryDal _categoryDal;
        public CategoryManager()
        {
            //dependecy injection
            _categoryDal = new EfCategoryDal();
        }

        public ResultMessage Add(Category entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation
            if (entity.Name.Length == 0)
            {
                result.Message = "Kategori adı belirtmelisiniz.";
                return result;
            }

            if (entity.Name.Length > 50)
            {
                result.Message = "Kategori adı için fazla karakter girdiniz.";
                return result;
            }
            #endregion

            try
            {
                _categoryDal.Add(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                //loglama
                result.Message = string.Format("Bir hata oluştu : {0}", e.Message);
                return result;
            }

            return result;
        }

        public ResultMessage Delete(Category entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation
        
            #endregion

            try
            {
                _categoryDal.Delete(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir hata oluştu : {0}", e.Message);
                return result;
            }
            return result;
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(id);
        }

        public IQueryable<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public ResultMessage Update(Category entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation
            if (entity.Name.Length == 0)
            {
                result.Message = "Kategori adı belirtmelisiniz.";
                return result;
            }

            if (entity.Name.Length > 50)
            {
                result.Message = "Kategori adı için fazla karakter girdiniz.";
                return result;
            }
            #endregion

            try
            {
                _categoryDal.Update(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir hata oluştu : {0}", e.Message);
                return result;
            }
            return result;
        }
    }
}
