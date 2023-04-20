using TecNM.Ecommerce.Core.Dto;

namespace TecNM.Ecommerce.Api.Services.Interfaces;

public interface IProductCategoryService
{
    //Metodo para guardar categorias
    Task<ProductCategoryDto> SaveAsync(ProductCategoryDto category);
    
    //Metodo para Actucalizar las categorias 
    Task<ProductCategoryDto> UpdateAsync(ProductCategoryDto category);
    
    //Metodo para retornar una lista de categorias
    Task<List<ProductCategoryDto>> GetAllAsync();
    
    //Metodo para retornar el id de las categorias que borrará
    Task<bool> ProductCategoryExist(int id);
    
    //Metodo para obtener una categoria por id
    Task<ProductCategoryDto> GetById(int id);
    
    //Metodo para retornar el id de las categorias que borrará
    Task<bool> DeleteAsync(int id);
}
