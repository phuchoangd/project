using StockExchanges.Model;
using StockExchanges.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchanges.Service
{
    public class commentService : EntityService<Post>, IcommentService
    {
        IUnitOfWork _unitOfWork;
        IPostRepository _postRepository;

        public commentService(IUnitOfWork unitOfWork, IPostRepository postRepository)
            : base(unitOfWork, postRepository)
        {
            _unitOfWork = unitOfWork;
            _postRepository = postRepository;
        }

        public Post GetById(long Id)
        {
            return _postRepository.GetById(Id);
        }
    }
}
