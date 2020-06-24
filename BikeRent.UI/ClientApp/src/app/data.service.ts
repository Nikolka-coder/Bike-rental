import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Bike } from './bike';
 
@Injectable()
export class DataService {
 
    private url = "/api/bikes";
 
    constructor(private http: HttpClient) {
    }
 
    getBikes() {
        return this.http.get(this.url);
    }
     
    getBike(id: number) {
        return this.http.get(this.url + '/' + id);
    }
     
    createBike(bike: Bike) {
        return this.http.post(this.url, bike);
    }
    updateBike(bike: Bike) {
  
        return this.http.put(this.url, bike);
    }
    deleteBike(id: number) {
        return this.http.delete(this.url + '/' + id);
    }
}