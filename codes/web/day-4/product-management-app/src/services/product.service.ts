import { ProductModel } from "src/models/product.model";
import { productRecords } from "../repository/productrepository";

/**
 * re-usable code
 */
//@Injectable()
export class ProductService {
    public getProducts(): ProductModel[] {
        return productRecords
    }
    public getProductById(pid: number): ProductModel | undefined {
        let foundProduct: ProductModel | undefined;
        for (let index = 0; index < productRecords.length; index++) {
            const product = productRecords[index];
            if (product.productId === pid) {
                foundProduct = product
                break;
            }
        }
        return foundProduct;
    }
    public addProduct(product: ProductModel) {

    }
    public deleteProduct(pid: number) {

    }
    public updateProduct(product: ProductModel) {

    }
}