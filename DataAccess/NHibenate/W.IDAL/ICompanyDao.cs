﻿using System.Collections;
using W.Model;

namespace W.IDAL
{
    public interface ICompanyDao
    {
        Company FindById(string  companyId);
        void Delete(Company  company);
        Company Save(Company company);
        Company SaveOrUpdate(Company  company);

    }
}
