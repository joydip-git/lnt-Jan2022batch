//1.A. class with public data members and constructor with arguments
/*
export class ProductModel {
    productId: number;
    productName: string;
    price: number;
    description: string;
    imagePath: string;

    constructor(id: number, name: string, price: number, desc: string, imgPath: string) {
        this.productId = id;
        this.productName = name;
        this.price = price;
        this.description = desc;
        this.imagePath = imgPath;
    }
}
*/

//1.B. class with constructor with public data members and arguments at the same time (short cut of writing 1.A)
/**
 * export class ProductModel {

    constructor(public productId: number, public productName: string, public price: number, public description: string, public imagePath: string) {

    }
}
 */

//2.A. private data members, constructor with arguments, public properties for data members
/*
export class ProductModel {
    private _productId: number;
    private _productName: string;
    private _price: number;
    private _description: string;
    private _imagePath: string;

    constructor(productId: number, productName: string, price: number, description: string, imagePath: string) {
        this._productId = productId;
        this._productName = productName;
        this._price = price;
        this._description = description;
        this._imagePath = imagePath;
    }
    public get imagePath(): string {
        return this._imagePath
    }
    public set imagePath(value: string) {
        this._imagePath = value
    }
    public get description(): string {
        return this._description
    }
    public set description(value: string) {
        this._description = value
    }
    public get price(): number {
        return this._price
    }
    public set price(value: number) {
        this._price = value
    }
    public get productId(): number {
        return this._productId
    }
    public set productId(value: number) {
        this._productId = value
    }

    public get productName(): string {
        return this._productName
    }
    public set productName(value: string) {
        this._productName = value
    }
}
*/

//2.A. constructor with private data members and arguments at the same time, public properties for data members (short cut for 2.A)
export class ProductModel {

    constructor(private _productId: number, private _productName: string, private _price: number, private _description: string, private _imagePath: string) {

    }

    public get imagePath(): string {
        return this._imagePath
    }
    public set imagePath(value: string) {
        this._imagePath = value
    }
    public get description(): string {
        return this._description
    }
    public set description(value: string) {
        this._description = value
    }
    public get price(): number {
        return this._price
    }
    public set price(value: number) {
        this._price = value
    }
    public get productId(): number {
        return this._productId
    }
    public set productId(value: number) {
        this._productId = value
    }

    public get productName(): string {
        return this._productName
    }
    public set productName(value: string) {
        this._productName = value
    }
}