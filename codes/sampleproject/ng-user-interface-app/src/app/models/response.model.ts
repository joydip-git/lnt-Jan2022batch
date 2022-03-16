import { ProductModel } from "./product.model";

export interface ResponseModel {
    statusCode: number;
    response: any;
    data: ProductModel | ProductModel[] | null | undefined
}