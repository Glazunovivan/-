import { Component, OnInit } from '@angular/core';
import { IStore } from 'src/app/models/store';
import { StoreService } from 'src/app/services/store.service';

@Component({
  selector: 'app-store',
  templateUrl: './store.component.html',
  styleUrls: ['./store.component.css']
})

export class StoreComponent implements OnInit{
  stores: IStore[]; 
  
  constructor(private StoreService: StoreService){ }
  
  ngOnInit(): void {
    this.StoreService.getStores().subscribe(
      (data)=>{
        this.stores = data;
        console.log(data);
      }
    );  
  }

  ngOnDestroy(){}
}
