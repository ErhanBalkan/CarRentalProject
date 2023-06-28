using Entities.Concrete;

namespace Business.Abstract;
public interface IColorService
{
    Color GetById(int colorId);
    List<Color> GetAll();
    void Add(Color color);
    void Update(Color color);
    void Delete(Color color);   
}