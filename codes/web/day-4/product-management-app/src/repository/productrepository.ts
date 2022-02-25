import { ProductModel } from "../models/product.model";

const leafRakeProduct = new ProductModel(1, "Leaf Rake", 19.95, "Leaf rake with 48-inch wooden handle.", "http://openclipart.org/image/300px/svg_to_png/26215/Anonymous_Leaf_Rake.png")

const gardenCartProduct = new ProductModel(2, "Garden Cart", 50, "15 gallon capacity rolling garden cart", "http://openclipart.org/image/300px/svg_to_png/58471/garden_cart.png")

const hammerProduct = new ProductModel(3, "Hammer", 100, "Curved claw steel hammer", "http://openclipart.org/image/300px/svg_to_png/73/rejon_Hammer.png")

const sawProduct = new ProductModel(4, "Saw", 23.45, "15-inch steel blade hand saw", "http://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png")

const videoGameControllerProduct = new ProductModel(5, "Video Game Controller", 35.95, "Standard two-button video game controller", "http://openclipart.org/image/300px/svg_to_png/120337/xbox-controller_01.png")

export const productRecords: ProductModel[] = [
    leafRakeProduct,
    gardenCartProduct,
    hammerProduct,
    sawProduct,
    videoGameControllerProduct
]

/*
//ProductModel[] productRecords = new Product[5];
const productRecords: ProductModel[] = new Array(5);
//const productRecords: ProductModel[] = []
productRecords.push(leafRakeProduct)
productRecords.push(sawProduct)
productRecords.push(hammerProduct)
productRecords.push(gardenCartProduct)
productRecords.push(videoGameControllerProduct)



// const productRecords: ProductModel[] = [leafRakeProduct, gardenCartProduct, hammerProduct, sawProduct, videoGameControllerProduct]

// const productRecords: ProductModel[] = new Array(leafRakeProduct, gardenCartProduct, sawProduct, hammerProduct, videoGameControllerProduct);
*/