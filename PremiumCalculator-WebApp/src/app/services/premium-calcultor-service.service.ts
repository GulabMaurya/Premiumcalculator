import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {Occupation} from '../dtos/occupation'
import { Premium } from '../dtos/premium';

@Injectable({
  providedIn: 'root'
})

export class PremiumCalcultorServiceService {

  apiUrl: string = "https://localhost:44368/";

  constructor(private http: HttpClient) { }

  getOccupation() {
    return this.http.get<Occupation[]>(this.apiUrl+`api/premium/getOccupation`);
  }

  calculatePremium(premiumDetails: Premium):any{
    let headers = new HttpHeaders();
    headers = headers.set('Content-Type', 'application/json; charset=utf-8');
    return this.http.post(this.apiUrl+`api/premium/calcPremium`,premiumDetails);
                    
}
}


