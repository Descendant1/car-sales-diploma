namespace AutoRiaBg.Application.CommandQueries.CarAd.Queries.GetCarAdsListByParameters
{
    using AutoRiaBg.Application.Interfaces;
    using AutoRiaBg.Domain.Entities;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetCarAdsShortViewByBrand : IRequest<List<Brand>>
    {
        public CarAdSearchModel searchModel { get; set; }



        public class GetCarAdsListByParametersHandler : IRequestHandler<GetCarAdsShortViewByBrand, List<Brand>>
        {
            private readonly IApplicationDbContext _context;
            public GetCarAdsListByParametersHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<Brand>> Handle(GetCarAdsShortViewByBrand request, CancellationToken cancellationToken = default)
            {
                
                //Retrieve fully joined data and filter by search object.
                //For short view trucate to shortview
                //For detail left it alone


                return null;
            }
        }


    }


    public class CarAdSearchModel
    {

        public CarAdSearchModel(Expression<Func<Brand, bool>> brandNamePredicate)
        {
            BrandNamePredicate = brandNamePredicate;
        }
        public Expression<Func<Brand, bool>> BrandNamePredicate { get;set; }
    }
}
