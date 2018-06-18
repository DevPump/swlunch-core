using System;
using swlunch.data;

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
