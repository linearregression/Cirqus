﻿using d60.Cirqus.MongoDb.Projections.Views;
using d60.Cirqus.Projections.Views.ViewManagers;
using d60.Cirqus.Tests.MongoDb;
using MongoDB.Driver;

namespace d60.Cirqus.Tests.Contracts.Views.Factories
{
    public class MongoDbManagedViewFactory : AbstractManagedViewFactory
    {
        readonly MongoDatabase _database;

        public MongoDbManagedViewFactory()
        {
            _database = MongoHelper.InitializeTestDatabase();
        }

        protected override IManagedView<TViewInstance> CreateManagedView<TViewInstance>()
        {
            var managedView = new MongoDbViewManager<TViewInstance>(_database);

            return managedView;
        }
    }
}