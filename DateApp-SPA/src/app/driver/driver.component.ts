import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-driver',
  templateUrl: './driver.component.html',
  styleUrls: ['./driver.component.css']
})
export class DriverComponent implements OnInit {
  drivers: any;

  constructor( private http: HttpClient) { }

  ngOnInit(): any {
    this.getDrivers();
  }


  getDrivers(): any{
    this.http.get('http://localhost:5000/api/drivers').subscribe(response => {
    this.drivers = response;
    }, error => {
      console.log(error);
    });
  }

}
