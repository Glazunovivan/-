import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IStore } from '../models/store';
import { Guid } from 'guid-typescript';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StoreService {

  url: string = "http://localhost:5228/api/stores";
  constructor(private http: HttpClient) { }

  getStores(): Observable<IStore[]> 
  {
    return this.http.get<IStore[]>(this.url);
  }

  getStore(id:Guid): Observable<IStore>
  {
    return this.http.get<IStore>(`${this.url}/${id}`);
  }
}
