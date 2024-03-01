import { Component } from '@angular/core';

@Component({
  selector: 'app-productlit',
  templateUrl: './productlit.component.html',
  styleUrl: './productlit.component.css'
})
export class ProductlitComponent {
  //Name: string = "Chair";
  //Price: number = 500;
  //Color : string ='Black'
  userRole: string = 'Nikhita';
  Product = {
    Name: 'Chair',
    Price: 500,
    Color: 'Black',
    Discount: 20,
    imgUrl: "https://www.nilkamalfurniture.com/cdn/shop/products/NS07SSGRN_1.jpg?v=1658837647&width=720"
  };
  name: string = '';
  getDiscountPrice() {
    return this.Product.Price-this.Product.Price * this.Product.Discount / 100
  }

  onClick() {
    alert("button clicked");
  }

 list:string[]=["Mark","Joe","baig"]

  productsList = [
    { id: 1, name: 'Product 1', price: 100 },
    { id: 2, name: 'Product 2', price: 200 },
    { id: 3, name: 'Product 3', price: 300 }
  ];
  
  color: string = 'red';
  }


