using ServiceFUEN.Models.EFModels;

namespace ServiceFUEN.Models.ViewModels
{
    public static partial class ProductExts
    {
        public static ProductDetailVM ToProductDetailVM(this Product product)
        {
            return new ProductDetailVM
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                BrandId= product.BrandId,
                CategoryId= product.CategoryId,
                ReleaseDate= product.ReleaseDate,
                ManufactorDate= product.ManufactorDate,
                ProductSpec = product.ProductSpec,
                Inventory= product.Inventory,
                Source = product.ProductPhotos.Select(x => x.Source).OrderBy(p=>p.Substring(0,2)).ToList(),
            };
        }
        public static ProductAllVM ToProductAllVM(this Product product)
        {
            return new ProductAllVM
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Source = product.ProductPhotos.Select(x => x.Source).Where(x=>x.Substring(0,2)=="01").ToList(),
            };
        }
        public static ProductNewVM ToProductNewVM(this Product product)
        {
            return new ProductNewVM
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ReleaseDate = product.ReleaseDate,
                Source = product.ProductPhotos.Select(x => x.Source).ToList(),
            };
        }
        public static CategoryVM ToCategoryVM(this Category category)
        {
            return new CategoryVM
            {
                 Id= category.Id,
                 Name = category.Name,
            };
        }
        public static BrandVM ToBrandVM(this Brand brand)
        {
            return new BrandVM
            {
                Id = brand.Id,
                Name = brand.Name,
            };
        }
        public static ProductSearchDTO ToProductSearchDTO(this Product product)
        {
            return new ProductSearchDTO
            {
                Id= product.Id,
                Name= product.Name,
                CategoryId= product.CategoryId,
                BrandId= product.BrandId,

            };
        }
        public static EventVM ToEventVM(this Event @event)
        {
            return new EventVM
            {
                Id = @event.Id,
                EventName = @event.EventName,
                Photo = @event.Photo,
                StartDate = @event.StartDate,
                EndDate = @event.EndDate,
            };
        }
        public static MeanPhotoVM ToMeanPhoto(this ProductPhoto mean)
        {
            return new MeanPhotoVM
            {
                Id = mean.Id,
                ProductId= mean.ProductId,
                Source= mean.Source,
              
            };
        }
    }
}
