import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { VehicleTypes } from '../Models/VehicleTypes';
import { VehicleService } from '../services/vehicle.service';
import { HttpErrorResponse } from "@angualr/common/http";
import { Vehicles } from '../Models/vehicle.model';


@Component({
    selector: 'app-vehicle-registration',
    templateUrl: './vehicle-registration.component.html',
    styleUrls: ['./vehicle-registration.component.css']
})
export class VehicleRegistrationComponent implements OnInit {

    private _vehicleregistration: FormGroup = this._fb.group({
        Manufacturer: ['',
            [Validators.required]
        ],
        Purchasedate: ['',
            [Validators.required]
        ],
        Model: [
            '',
            [Validators.required]
        ],

        DrivingLicenseNumber: ['', [Validators.required]],
        RegistrationNumber: [
            '',
            [
                Validators.required

            ]
        ],
        EngineNumber: [
            '',
            [
                Validators.required

            ]
        ],
        ChasisNumber: [
            '',
            [
                Validators.required

            ]

        ]

    }




    );
    public get vehicleregistration(): FormGroup {
        return this._vehicleregistration;
    }
    public set vehicleregistration(value: FormGroup) {
        this._vehicleregistration = value;
    }

    constructor(private _fb: FormBuilder, private vs: VehicleService) { }

    vehileTypesData?: VehicleTypes[];
    ngOnInit(): void {
        this.vs.getVehicleTypes().subscribe({
            next: (data: VehicleTypes[]) => this.vehileTypesData = data,
            error: (err: HttpErrorResponse) => console.log(err),
            complete: () => console.log('done')
        });
    }

    vehicleTypeId?: number;
    chooseVehileType(vehicletypeId: number) {
        this.vehicleTypeId = vehicletypeId;
    }
    submitData() {
        console.log(this._vehicleregistration.value)
        const vehilceData: Vehicles = {
            ...this._vehicleregistration,
            vehicleTypeId: this.vehicleTypeId
        };
        this.vs.addVehicleData(vehilceData)
    }
}





