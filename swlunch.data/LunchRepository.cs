using System;

namespace swlunch.data{    
    public class LunchRepository {
        private lunchContext _context;

        // private lunchContext _context;
        public LunchRepository(lunchContext context){
            _context = context;
        }
        public Restaurants getRestaurants(){
            return _context.Restaurants.Find(1);
        }
    }
}