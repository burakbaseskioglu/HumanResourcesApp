﻿using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Dto.Work;

namespace HumanResources.Business.Abstract
{
    public interface IWorkBusiness
    {
        IResult Add(WorkInsertDto workInsertDto);
        IDataResult<IEnumerable<WorkDto>> GetAll();
        IResult Delete(Guid workId);
        IResult Update(WorkUpdateDto workUpdateDto);
    }
}
