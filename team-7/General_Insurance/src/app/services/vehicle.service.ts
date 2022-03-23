import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { VehicleTypes } from '../Models/VehicleTypes';
import { Vehicles } from '../Models/vehicle.model';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {

  private url = 'http://localhost:45903/api/Buyinsurance';
  constructor(private _http: HttpClient) { }
  public getVehicleTypes() {
    return this._http.get<VehicleTypes>(this.url + "/vehicletypes");
  }
  public addVehicleData(v: Vehicles) {
    return this._http.post(this.url + "/" + "", v);
  }
}
