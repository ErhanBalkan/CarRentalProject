using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Business.Concrete;
public class ColorManager : IColorService
{
    readonly IColorDal _colorDal;
    public ColorManager(IColorDal colorDal)
    {
        _colorDal = colorDal;
    }
    public void Add(Color color)
    {
        _colorDal.Add(color);
    }

    public void Delete(Color color)
    {
        _colorDal.Delete(color);
    }

    public List<Color> GetAll()
    {
        return _colorDal.GetAll();
    }

    public Color GetById(int colorId)
    {
        return _colorDal.Get(clr => clr.ColorId == colorId);
    }

    public void Update(Color color)
    {
        _colorDal.Update(color);
    }
}