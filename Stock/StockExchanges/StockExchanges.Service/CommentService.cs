using StockExchanges.Model;
using StockExchanges.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchanges.Service
{
    public class CommentService : EntityService<Comment>, ICommentService
    {
        IUnitOfWork _unitOfWork;
        ICommentRepository _commentRepository;

        public CommentService(IUnitOfWork unitOfWork, ICommentRepository commentRepository)
            : base(unitOfWork, commentRepository)
        {
            _unitOfWork = unitOfWork;
            _commentRepository = commentRepository;
        }

        public Comment GetById(long Id)
        {
            return _commentRepository.GetById(Id);
        }
    }
}
