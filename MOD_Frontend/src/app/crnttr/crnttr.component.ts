import { Component, OnInit } from '@angular/core';
import { Training } from '../_Models/training';
import { TrainingService } from '../_Services/training.service';

@Component({
  selector: 'app-crnttr',
  templateUrl: './crnttr.component.html',
  styleUrls: ['./crnttr.component.css']
})
export class CrnttrComponent implements OnInit {
  item:Training;
  list:Training[];
  msg:string;

  constructor(private _service: TrainingService) {
    this.item=new Training();
    this._service.GetAll('In Progress').subscribe(k=>
      {
        this.list=k;
        console.log(this.list);
      })
   }

  ngOnInit() {

  }

}
