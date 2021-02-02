using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IStudentRepository Student { get; }
        IAccountRepository Account { get; }
        void Save();
    }
}
