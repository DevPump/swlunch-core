using System;
using swlunch.data;
using swlunch.data.context;
using swlunch.data.models;

namespace swlunch.service
{
    public class LunchService
    {
        private LunchRepository _repository;
        public LunchService (lunchContext context){
            _repository = new LunchRepository(context);
        }
        public Restaurants testClass(){
            return _repository.getRestaurants();
        }
    }
}
