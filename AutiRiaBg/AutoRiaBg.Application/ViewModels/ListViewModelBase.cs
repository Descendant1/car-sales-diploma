using AutoRiaBg.Domain;
using AutoRiaBg.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoRiaBg.Application.ViewModels
{
    public abstract class ListViewModelBase<T> where T : AuditableEntity
    {
        public List<T> Data { get; set; }
    }

    public class CarAdsListViewModel : ListViewModelBase<CarAd>
    {

    }
}
