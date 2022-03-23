export interface Vehicles {
    vehicleTypeId?: number;
    manufacturer: string;
    model: string;
    drivingLicenseNumber: string;
    registrationNumber: string;
    engineNumber: string;
    chasisNumber: string;
    purchaseDate: Date;
    customerId?: number;
}