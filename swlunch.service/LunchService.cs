using System;
using swlunch.data;
using swlunch.data.context;
using swlunch.data.models;

namespace swlunch.service
{
    public class LunchService
    {
        private lunchContext _context;

        public LunchService (lunchContext context){
            _context = context;
        }
        public Restaurants getRestaurants(){
            return _context.Restaurants.Find(1);
        }
    }
}
