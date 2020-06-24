import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { Bike } from './bike';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [DataService]
})
export class AppComponent implements OnInit {
 
  bike: Bike = new Bike();   
  bikes: Bike[];                
  tableMode: boolean = true;          

  constructor(private dataService: DataService) { }

  ngOnInit() {
      this.loadBikes();    
  }
  
  loadBikes() {
      this.dataService.getBikes()
          .subscribe((data: Bike[]) => this.bikes = data);
  }
  // сохранение данных
  save() {
      if (this.bike.id == null) {
          this.dataService.createBike(this.bike)
              .subscribe((data: Bike) => this.bikes.push(data));
      } else {
          this.dataService.updateBike(this.bike)
              .subscribe(data => this.loadBikes());
      }
      this.cancel();
  }
  editBike(b: Bike) {
      this.bike = b;
  }
  cancel() {
      this.bike = new Bike();
      this.tableMode = true;
  }
  delete(b: Bike) {
      this.dataService.deleteBike(b.id)
          .subscribe(data => this.loadBikes());
  }
  add() {
      this.cancel();
      this.tableMode = false;
  }
}
