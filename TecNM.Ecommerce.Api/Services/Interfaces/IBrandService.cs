using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Services.Interfaces;

public interface IBrandService
{
    //Metodo para guardar categorias
    Task<BrandDto> SaveAsync(BrandDto brand);
    
    //Metodo para Actucalizar las categorias 
    Task<BrandDto> UpdateAsync(BrandDto brand);
    
    //Metodo para retornar una lista de categorias
    Task<List<BrandDto>> GetAllAsync();
    
    //Metodo para retornar el id de las categorias que borrará
    Task<bool> BrandExist(int id);
    
    //Metodo para obtener una categoria por id
    Task<BrandDto> GetById(int id);

    //Metodo para retornar el id de las categorias que borrará
    Task<bool> DeleteAsync(int id);
}