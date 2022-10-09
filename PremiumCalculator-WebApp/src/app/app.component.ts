import { Component, OnInit } from '@angular/core';
import { PremiumCalcultorServiceService } from '../app/services/premium-calcultor-service.service';
import { Occupation } from '../app/dtos/occupation';
import { Premium } from './dtos/premium';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent {
  title = 'PremiumCalculator';
  premiumParameters: Premium = { name: "", dOB: "", age: 0, occupation: "", sumInsured: 0 };
  occupationList: Occupation[]=[];
  calculatedPremium: any;
  constructor(private _premiumCalc: PremiumCalcultorServiceService) {

  }

  ngOnInit() {
    this._premiumCalc.getOccupation().subscribe(x => {     
      this.occupationList = x;

    });
  }
  CalculatePremium() {
    this.premiumParameters.age = this.CalculateAge(this.premiumParameters.dOB);
    this._premiumCalc.calculatePremium(this.premiumParameters).subscribe((x: any) => {
    this.calculatedPremium=x;
       });


  }
  CalculateAge(dob: any) {
    let date = new Date(dob);
    let timeDiff = Math.abs(Date.now() - date.getTime());
    return Math.floor((timeDiff / (1000 * 3600 * 24)) / 365.25);


  }
}
