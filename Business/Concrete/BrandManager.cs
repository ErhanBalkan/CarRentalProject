using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;
public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public void Add(Brand brand)
    {
        _brandDal.Add(brand);
    }

    public void Delete(Brand brand)
    {
        _brandDal.Delete(brand);
    }

    public List<Brand> GetAll()
    {
        return _brandDal.GetAll();
    }

    public Brand GetById(int brandId)
    {
        return _brandDal.Get(b => b.BrandId == brandId);
    }

    public void Update(Brand brand)
    {
        _brandDal.Update(brand);
    }
}