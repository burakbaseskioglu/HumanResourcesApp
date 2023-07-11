using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Dto.Certificate;
using HumanResources.Entities.Dto.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Business.Abstract
{
    public interface ICertificateBusiness
    {
        IResult Add(CertificateInsertDto certificateInsertDto);
        IDataResult<IEnumerable<CertificateDto>> GetAll();
        IResult Delete(Guid certificateId);
        IResult Update(CertificateUpdateDto certificateUpdateDto);
    }
}
