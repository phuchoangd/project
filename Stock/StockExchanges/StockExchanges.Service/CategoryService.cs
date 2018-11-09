using StockExchanges.Model;
using StockExchanges.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchanges.Service
{
    public class CategoryService : EntityService<Category>, ICategoryService
    {
        IUnitOfWork _unitOfWork;
        ICategoryRepository _categoryRepository;

        public CategoryService(IUnitOfWork unitOfWork, ICategoryRepository categoryRepository)
            : base(unitOfWork, categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }


        public Category GetById(int Id)
        {
            return _categoryRepository.GetById(Id);
        }
    }
}
