﻿using System;
using AbstractFactory.MyPizzaStore.Abstract_Classes;
using AbstractFactory.MyPizzaStore.Interfaces;

namespace AbstractFactory.MyPizzaStore.Concrete_Classes.Pizza_Extensions {
    class CheesePizza : Pizza {
        public CheesePizza(PizzaIngredientFactory ingredientFactory) {
            _IngredientFactory = ingredientFactory;
        }

        public override void Prepare() {
            Console.WriteLine("Preparing " + _Name);
            _Dough = _IngredientFactory.CreateDough();
            _Sauce = _IngredientFactory.CreateSauce();
            _Cheese = _IngredientFactory.CreateCheese();
        }
    }
}
